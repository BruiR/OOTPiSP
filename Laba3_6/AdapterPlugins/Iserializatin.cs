using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPlugins
{
    interface Iserialization
    {
        string MakeSerialize(List<object> School_worker, string fileName);
        List<object> MakeDeserialize(string fileName);
    }
}
