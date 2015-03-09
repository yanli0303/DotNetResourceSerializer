namespace DotNetResxConverter
{
    public class ResxItem : ResxItemNoCmt
    {
        public string Comment { get; set; }
    }

    public class ResxItemNoCmt
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
