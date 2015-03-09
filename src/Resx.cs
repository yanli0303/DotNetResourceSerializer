using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DotNetResxConverter
{
    public class Resx
    {
        public List<ResxItem> Items;

        public Resx(List<ResxItem> items)
        {
            Items = items;
        }

        //All "comment" will be lost.
        //public static Resx Load(string fileName)
        //{
        //    using (var reader = new ResourceReader(fileName))
        //    {
        //        var items = new List<ResxItem>(100);
        //        var enu = reader.GetEnumerator();
        //        while (enu.MoveNext())
        //        {
        //            var key = enu.Entry.Key as string;
        //            if (null == key)
        //            {
        //                continue;
        //            }

        //            var value = enu.Entry.Value as string;
        //            items.Add(new ResxItem
        //            {
        //                Name = key,
        //                Value = value
        //            });
        //        }

        //        return new Resx(items);
        //    }
        //}

        //Load resource file as plain xml, "comment" remains.
        public static Resx LoadXml(string fileName)
        {
            var doc = XDocument.Load(fileName);

            Func<XElement, string, string> getAttributeValue = (it, name) =>
            {
                var attr = it.Attribute(name);
                return null == attr ? null : attr.Value;
            };

            Func<XElement, string, string> getElementValue = (it, name) =>
            {
                var e = it.Element(name);
                return null == e ? null : e.Value;
            };

            var items = doc.Root.Descendants("data")
                .Select(it => new ResxItem
                {
                    Name = getAttributeValue(it, "name"),
                    Value = getElementValue(it, "value"),
                    Comment = getElementValue(it, "comment")
                })
                .Where(it => null != it.Name)
                .ToList();

            return new Resx(items);
        }
    }
}
