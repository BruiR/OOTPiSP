using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Administrator: School_worker
    {
        public enum Departments
        {
            Financy,
            Management,
            Personnel, 
            Study,
            Education,
            Science
        }

        public Departments Department {get; set;}
    }
}
