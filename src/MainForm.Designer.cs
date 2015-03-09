namespace DotNetResxConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbResxFolder = new System.Windows.Forms.TextBox();
            this.btnSelectResxFolder = new System.Windows.Forms.Button();
            this.btnConvertResxToJson = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpResxToJson = new System.Windows.Forms.TabPage();
            this.ckRecursive = new System.Windows.Forms.CheckBox();
            this.ckCompactJsonFormat = new System.Windows.Forms.CheckBox();
            this.ckJavaScriptOutput = new System.Windows.Forms.CheckBox();
            this.ckInoreComments = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbResxToJsonPreview = new System.Windows.Forms.TextBox();
            this.lbResxToJsonFiles = new System.Windows.Forms.ListBox();
            this.tpJsonToResx = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpResxToJson.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpJsonToResx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResxFolder
            // 
            this.tbResxFolder.BackColor = System.Drawing.Color.White;
            this.tbResxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResxFolder.Location = new System.Drawing.Point(68, 17);
            this.tbResxFolder.Name = "tbResxFolder";
            this.tbResxFolder.ReadOnly = true;
            this.tbResxFolder.Size = new System.Drawing.Size(586, 20);
            this.tbResxFolder.TabIndex = 0;
            // 
            // btnSelectResxFolder
            // 
            this.btnSelectResxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectResxFolder.Location = new System.Drawing.Point(662, 16);
            this.btnSelectResxFolder.Name = "btnSelectResxFolder";
            this.btnSelectResxFolder.Size = new System.Drawing.Size(130, 23);
            this.btnSelectResxFolder.TabIndex = 1;
            this.btnSelectResxFolder.Text = "Cho&ose Folder...";
            this.btnSelectResxFolder.UseVisualStyleBackColor = true;
            this.btnSelectResxFolder.Click += new System.EventHandler(this.btnSelectResx_Click);
            // 
            // btnConvertResxToJson
            // 
            this.btnConvertResxToJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertResxToJson.Location = new System.Drawing.Point(798, 16);
            this.btnConvertResxToJson.Name = "btnConvertResxToJson";
            this.btnConvertResxToJson.Size = new System.Drawing.Size(130, 23);
            this.btnConvertResxToJson.TabIndex = 4;
            this.btnConvertResxToJson.Text = "&Convert Selected";
            this.btnConvertResxToJson.UseVisualStyleBackColor = true;
            this.btnConvertResxToJson.Click += new System.EventHandler(this.btnConvertResxToJson_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpResxToJson);
            this.tabControl1.Controls.Add(this.tpJsonToResx);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 647);
            this.tabControl1.TabIndex = 1;
            // 
            // tpResxToJson
            // 
            this.tpResxToJson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpResxToJson.Controls.Add(this.ckRecursive);
            this.tpResxToJson.Controls.Add(this.ckCompactJsonFormat);
            this.tpResxToJson.Controls.Add(this.ckJavaScriptOutput);
            this.tpResxToJson.Controls.Add(this.ckInoreComments);
            this.tpResxToJson.Controls.Add(this.panel1);
            this.tpResxToJson.Controls.Add(this.tbResxFolder);
            this.tpResxToJson.Controls.Add(this.btnSelectResxFolder);
            this.tpResxToJson.Controls.Add(this.btnConvertResxToJson);
            this.tpResxToJson.Location = new System.Drawing.Point(4, 25);
            this.tpResxToJson.Name = "tpResxToJson";
            this.tpResxToJson.Padding = new System.Windows.Forms.Padding(3);
            this.tpResxToJson.Size = new System.Drawing.Size(1000, 618);
            this.tpResxToJson.TabIndex = 0;
            this.tpResxToJson.Text = "From .NET Resource";
            // 
            // ckRecursive
            // 
            this.ckRecursive.AutoSize = true;
            this.ckRecursive.Checked = true;
            this.ckRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRecursive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckRecursive.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRecursive.Location = new System.Drawing.Point(68, 56);
            this.ckRecursive.Name = "ckRecursive";
            this.ckRecursive.Size = new System.Drawing.Size(216, 22);
            this.ckRecursive.TabIndex = 3;
            this.ckRecursive.Text = "&Including Subdirectories";
            this.ckRecursive.UseVisualStyleBackColor = true;
            this.ckRecursive.CheckedChanged += new System.EventHandler(this.ckRecursive_CheckedChanged);
            // 
            // ckCompactJsonFormat
            // 
            this.ckCompactJsonFormat.AutoSize = true;
            this.ckCompactJsonFormat.Checked = true;
            this.ckCompactJsonFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCompactJsonFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckCompactJsonFormat.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCompactJsonFormat.Location = new System.Drawing.Point(296, 55);
            this.ckCompactJsonFormat.Name = "ckCompactJsonFormat";
            this.ckCompactJsonFormat.Size = new System.Drawing.Size(112, 22);
            this.ckCompactJsonFormat.TabIndex = 3;
            this.ckCompactJsonFormat.Text = "Com&pat mode";
            this.ckCompactJsonFormat.UseVisualStyleBackColor = true;
            this.ckCompactJsonFormat.CheckedChanged += new System.EventHandler(this.common_refreshPreview);
            // 
            // ckJavaScriptOutput
            // 
            this.ckJavaScriptOutput.AutoSize = true;
            this.ckJavaScriptOutput.CausesValidation = false;
            this.ckJavaScriptOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckJavaScriptOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckJavaScriptOutput.Location = new System.Drawing.Point(642, 55);
            this.ckJavaScriptOutput.Name = "ckJavaScriptOutput";
            this.ckJavaScriptOutput.Size = new System.Drawing.Size(160, 22);
            this.ckJavaScriptOutput.TabIndex = 2;
            this.ckJavaScriptOutput.Text = "JavaScript output";
            this.ckJavaScriptOutput.UseVisualStyleBackColor = true;
            this.ckJavaScriptOutput.CheckedChanged += new System.EventHandler(this.common_refreshPreview);
            // 
            // ckInoreComments
            // 
            this.ckInoreComments.AutoSize = true;
            this.ckInoreComments.Checked = true;
            this.ckInoreComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckInoreComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckInoreComments.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckInoreComments.Location = new System.Drawing.Point(420, 55);
            this.ckInoreComments.Name = "ckInoreComments";
            this.ckInoreComments.Size = new System.Drawing.Size(216, 22);
            this.ckInoreComments.TabIndex = 2;
            this.ckInoreComments.Text = "Ignore Resource Co&mments";
            this.ckInoreComments.UseVisualStyleBackColor = true;
            this.ckInoreComments.CheckedChanged += new System.EventHandler(this.common_refreshPreview);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbResxToJsonPreview);
            this.panel1.Controls.Add(this.lbResxToJsonFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 517);
            this.panel1.TabIndex = 6;
            // 
            // tbResxToJsonPreview
            // 
            this.tbResxToJsonPreview.BackColor = System.Drawing.Color.Black;
            this.tbResxToJsonPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResxToJsonPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbResxToJsonPreview.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResxToJsonPreview.ForeColor = System.Drawing.Color.Lime;
            this.tbResxToJsonPreview.Location = new System.Drawing.Point(212, 0);
            this.tbResxToJsonPreview.Multiline = true;
            this.tbResxToJsonPreview.Name = "tbResxToJsonPreview";
            this.tbResxToJsonPreview.Size = new System.Drawing.Size(780, 517);
            this.tbResxToJsonPreview.TabIndex = 1;
            this.tbResxToJsonPreview.Text = "Select a resource file from left to preview the output.";
            // 
            // lbResxToJsonFiles
            // 
            this.lbResxToJsonFiles.BackColor = System.Drawing.Color.White;
            this.lbResxToJsonFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResxToJsonFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbResxToJsonFiles.ForeColor = System.Drawing.Color.Black;
            this.lbResxToJsonFiles.FormattingEnabled = true;
            this.lbResxToJsonFiles.Location = new System.Drawing.Point(0, 0);
            this.lbResxToJsonFiles.Name = "lbResxToJsonFiles";
            this.lbResxToJsonFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbResxToJsonFiles.Size = new System.Drawing.Size(196, 517);
            this.lbResxToJsonFiles.TabIndex = 1;
            this.lbResxToJsonFiles.SelectedIndexChanged += new System.EventHandler(this.common_refreshPreview);
            // 
            // tpJsonToResx
            // 
            this.tpJsonToResx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpJsonToResx.Controls.Add(this.textBox1);
            this.tpJsonToResx.Location = new System.Drawing.Point(4, 25);
            this.tpJsonToResx.Name = "tpJsonToResx";
            this.tpJsonToResx.Padding = new System.Windows.Forms.Padding(3);
            this.tpJsonToResx.Size = new System.Drawing.Size(1000, 618);
            this.tpJsonToResx.TabIndex = 1;
            this.tpJsonToResx.Text = "To .NET Resource";
            this.tpJsonToResx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(43, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(862, 48);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Not implemented yet";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTip
            // 
            this.tbTip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTip.CausesValidation = false;
            this.tbTip.Enabled = false;
            this.tbTip.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTip.Location = new System.Drawing.Point(47, 12);
            this.tbTip.Multiline = true;
            this.tbTip.Name = "tbTip";
            this.tbTip.ReadOnly = true;
            this.tbTip.Size = new System.Drawing.Size(862, 48);
            this.tbTip.TabIndex = 0;
            this.tbTip.Text = "Converts .NET Resource files (.resx) to JSON, vice versa.\r\nNote that only text re" +
    "source items are supported for now.";
            this.tbTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Resource file converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpResxToJson.ResumeLayout(false);
            this.tpResxToJson.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpJsonToResx.ResumeLayout(false);
            this.tpJsonToResx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResxFolder;
        private System.Windows.Forms.Button btnSelectResxFolder;
        private System.Windows.Forms.Button btnConvertResxToJson;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpResxToJson;
        private System.Windows.Forms.TabPage tpJsonToResx;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbResxToJsonFiles;
        private System.Windows.Forms.TextBox tbResxToJsonPreview;
        private System.Windows.Forms.CheckBox ckCompactJsonFormat;
        private System.Windows.Forms.CheckBox ckInoreComments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckRecursive;
        private System.Windows.Forms.CheckBox ckJavaScriptOutput;
    }
}

