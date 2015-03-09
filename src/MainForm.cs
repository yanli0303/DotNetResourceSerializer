using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DotNetResxConverter
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private class ListBindItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private string GetClientJS(string fileName)
        {
            var resx = Resx.LoadXml(fileName);
            var name = Path.GetFileNameWithoutExtension(fileName);
            var ignoreCmt = ckInoreComments.Checked;
            var compact = ckCompactJsonFormat.Checked;
            Func<string, string> fnEscapse = it =>
            {
                return it.Replace("\"", "\\\"");
            };
            Func<ResxItem, string> fnCompact = it =>
            {
                return string.Concat
                (
                    ignoreCmt || string.IsNullOrWhiteSpace(it.Comment) ? string.Empty : "/*" + it.Comment + "*/",
                    "\"", fnEscapse(it.Name), "\":\"", fnEscapse(it.Value), "\""
                );
            };
            Func<ResxItem, string> fnFull = it =>
            {
                return string.Concat
                (
                    ignoreCmt || string.IsNullOrWhiteSpace(it.Comment) ? string.Empty : "    //" + it.Comment + Environment.NewLine,
                    "    \"", fnEscapse(it.Name), "\" : \"", fnEscapse(it.Value), "\""
                );
            };

            var jsItems = resx.Items.Select(it => compact ? fnCompact(it) : fnFull(it)).ToArray();
            return string.Concat
            (
                ";var ", name, compact ? "={" : " = {",
                compact ? string.Empty : Environment.NewLine,
                string.Join(compact ? "," : "," + Environment.NewLine, jsItems),
                compact ? string.Empty : Environment.NewLine,
                "};"
            );
        }

        private string GetJson(string fileName)
        {
            var resx = Resx.LoadXml(fileName);
            object jObject = resx.Items;
            if (ckInoreComments.Checked)
            {
                jObject = resx.Items.Select(it => new ResxItemNoCmt
                {
                    Name = it.Name,
                    Value = it.Value
                }).ToList();
            }

            return ckCompactJsonFormat.Checked ? JsonHelper.ToJsonByNewton(jObject) : JsonHelper.ToFormattedJson(jObject);
        }

        private void RefreshPreview()
        {
            var item = lbResxToJsonFiles.SelectedItem as ListBindItem;
            if (null == item)
            {
                return;
            }

            tbResxToJsonPreview.Text = ckJavaScriptOutput.Checked ? GetClientJS(item.Value) : GetJson(item.Value);
        }

        private void BindFileList(ListBox bindTo, string path, string fileType)
        {
            var files = Directory
                .EnumerateFiles(path, fileType, ckRecursive.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                .Select(it => new ListBindItem
                {
                    Text = it.Substring(path.Length + 1),// Path.GetFileName(it),
                    Value = it
                })
                .ToArray();

            bindTo.Items.Clear();
            bindTo.Items.AddRange(files);
            tbResxToJsonPreview.Text = "Select a resource file from left to preview the output.";
        }

        private void btnSelectResx_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = string.IsNullOrEmpty(tbResxFolder.Text) ? Environment.CurrentDirectory : tbResxFolder.Text;
                dlg.ShowNewFolderButton = false;
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbResxToJsonPreview.Text = string.Empty;
                    tbResxFolder.Text = dlg.SelectedPath;
                    BindFileList(lbResxToJsonFiles, dlg.SelectedPath, "*.resx");
                }
            }
        }

        private void btnConvertResxToJson_Click(object sender, EventArgs e)
        {
            if (lbResxToJsonFiles.Items.Count == 0)
                return;

            var items = lbResxToJsonFiles.SelectedItems;
            if (items.Count == 0)
            {
                MessageBox.Show("Please select one or more .NET resource files from the list on bottom left.",
                    "No resource files are selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var isJson = !ckJavaScriptOutput.Checked;
            var extension = isJson ? ".json" : ".js";
            var anyError = false;
            foreach (ListBindItem item in lbResxToJsonFiles.SelectedItems)
            {
                var fileName = Path.GetFileNameWithoutExtension(item.Value) + extension;
                fileName = Path.Combine(Path.GetDirectoryName(item.Value), fileName);

                var json = isJson ? GetJson(item.Value) : GetClientJS(item.Value);
                try
                {
                    if (File.Exists(fileName))
                    {
                        var bak = fileName + ".bak";
                        if (File.Exists(bak))
                        {
                            File.Delete(bak);
                        }

                        File.Move(fileName, bak);
                    }

                    File.AppendAllText(fileName, json, Encoding.UTF8);
                }
                catch
                {
                    var goon = MessageBox.Show("Unable to create:\n\t"
                        + fileName
                        + "\n or create a backup of exist file: \n\t"
                        + fileName + ".bak",

                    "Error: " + item.Value,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);

                    if (goon == DialogResult.Cancel)
                    {
                        anyError = true;
                        break;
                    }
                }
            }

            if (!anyError)
            {
                MessageBox.Show(
                    "Selected resources have been converted, see the new " + extension + " files within same folder.",
                    "Converted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void common_refreshPreview(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var path = Environment.CurrentDirectory;
            tbResxFolder.Text = path;
            BindFileList(lbResxToJsonFiles, path, "*.resx");
        }

        private void ckRecursive_CheckedChanged(object sender, EventArgs e)
        {
            var path = string.IsNullOrWhiteSpace(tbResxFolder.Text) ? Environment.CurrentDirectory : tbResxFolder.Text;
            BindFileList(lbResxToJsonFiles, path, "*.resx");
        }
    }
}
