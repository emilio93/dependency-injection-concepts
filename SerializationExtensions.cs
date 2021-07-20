using System;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DependencyInjection
{
    public static class SerializationExtensions
    {
        public static string ToXml(this object o)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                NewLineOnAttributes = true
            };
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    xmlSerializer.Serialize(writer, o);
                    string xml = sww.ToString();
                    return xml;
                }
            }

        }

        public static T FromXml<T>(this string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public static string ToJson(this object o)
        {
            var settings = new JsonSerializerOptions()
            {
                IgnoreNullValues = false,
                WriteIndented = true
            };
            return JsonSerializer.Serialize(o, settings);
        }

        public static T FromJson<T>(this string json)
        {
            return (T)JsonSerializer.Deserialize<T>(json);
        }
    }
}
