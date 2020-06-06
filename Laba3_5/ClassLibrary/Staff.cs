using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    abstract public class Staff: School_worker
    {
        public enum Uniforms { 
        yes,
        no
        }
        public Uniforms Uniform { get; set; }
    }
}
