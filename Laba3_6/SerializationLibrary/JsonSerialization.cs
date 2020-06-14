using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SerializationLibrary
{
    public class JsonSerialization : ISerialization
    {
        public const string filters = "json файл (*.json)|*.json";
        public const string format = ".json";
        public string MakeSerialize(List<object> School_workers, string fileName)
        {
            try
            {
                using (StreamWriter f = new StreamWriter(fileName, false, System.Text.Encoding.Default))
                {
                    foreach (var element in School_workers)
                    {
                        var settings = new JsonSerializerSettings()
                        {
                            TypeNameHandling = TypeNameHandling.All
                        };
                        var result = JsonConvert.SerializeObject(element, settings);
                        f.WriteLine(result);
                    }
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<object> MakeDeserialize(string fileName)
        {
            List<object> Objects = new List<object>();
            using (StreamReader f = new StreamReader(fileName))
            {
                while (!f.EndOfStream)
                {
                    string result = f.ReadLine();
                    var settings = new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };
                    var ObjectsList = JsonConvert.DeserializeObject(result, settings);
                    Objects.Add(ObjectsList);
                }
            }
            return Objects;
        }
    }
}
