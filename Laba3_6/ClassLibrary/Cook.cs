using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Categories
    {first,
    second,
    thirth,
    fourth,
    fifth,
    sixth
    }
    [Serializable]
    public class Cook: Staff
    {
        public Categories Cook_category {get; set;}
    }
}
