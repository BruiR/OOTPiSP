using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Teacher: School_worker
    {
        public enum Subjects
        {
            Math,
            History,
            Russian,
            Belarusian,
            English,
            Geography,
            Informatic,
            Physics,
            Chemistry,
            Biology,
            Physical_culture
        }

        public Subjects Subject {get; set;}
    }
}
