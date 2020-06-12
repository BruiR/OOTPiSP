using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum Places
    {
        indoor,
        outdoor
    }
    [Serializable]
    public class Cleaner: Staff
    {
        public Places Place_of_work {get; set;}
    }
}
