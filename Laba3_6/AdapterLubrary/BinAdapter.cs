using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary
{
   public class BinAdapter : Library.BinarySerialization, ISerializator
    {
        public string MakeSerialize(List<object> School_worker, string fileName) 
        {
            return this.ToSerialize(School_worker, fileName);
            
        }

        public List<object> MakeDeserialize(string fileName) 
        {
            return this.ToDeserialize(fileName);
        }
    }
}