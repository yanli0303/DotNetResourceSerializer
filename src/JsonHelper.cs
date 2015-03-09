using System.IO;
using Newtonsoft.Json;

namespace DotNetResxConverter
{
    public static class JsonHelper
    {
        public static string ToJsonByNewton(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T FromJsonByNewton<T>(string jsonString)
        {
            if (string.IsNullOrWhiteSpace(jsonString))
                return default(T);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public static object FromJsonByNewton(string jsonString)
        {
            if (string.IsNullOrWhiteSpace(jsonString))
                return null;

            return JsonConvert.DeserializeObject(jsonString);
        }

        public static string ToFormattedJson(object obj)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StringWriter())
            {
                var writer = new JsonTextWriter(sw);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                writer.IndentChar = ' ';
                serializer.Serialize(writer, obj);
                return sw.ToString();
            }
        }

        public static string FormatJson(string jsonString)
        {
            var jObject = FromJsonByNewton(jsonString);
            if (null == jObject)
                return null;

            return ToFormattedJson(jObject);
        }
    }
}
