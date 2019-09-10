using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

namespace WCFServicesApp.Helpers
{
    public class Serializer
    {
        public static T JsonStringToEntity<T>(string json) where T : class
        {   
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string EntityToJsonString<T>(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }

        public static string EntityToXmlString<T>(T entity)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(entity.GetType());

            using (StringWriter sw = new StringWriter())
            {
                xmlSerializer.Serialize(sw, entity);
                return sw.ToString();
            }
        }
        public static T XmlStringToEntity<T>(string str) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(str))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}