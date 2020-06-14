using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BinarySerialization 
    {
        public string ToSerialize(List<object> objetcs, string fileName)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream f = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(f, objetcs);
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<object> ToDeserialize(string fileName)
        {
            List<object> ObjectsList = new List<object>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream(fileName, FileMode.Open))
            {
                var result = formatter.Deserialize(f);
                foreach (var element in (result as List<object>))
                {
                    ObjectsList.Add(element);
                }
            }
            return ObjectsList;
        }
    }
}
