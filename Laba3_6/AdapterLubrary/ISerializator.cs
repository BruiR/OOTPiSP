using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary
{
    interface ISerializator
    {
        string MakeSerialize(List<object> School_worker, string fileName);
        List<object> MakeDeserialize(string fileName);
    }
}
