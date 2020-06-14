using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    sealed public class About_worker
    {
        public string FieldEducation;
        public string Education {
            get {
                return FieldEducation;
            }
            set {
                if ((value.Length == 0) || (value.Length>10)) {
                    FieldEducation = "error";
                }
                else {
                    FieldEducation = value;
                }
            }
        }
        public int FieldSalary;
        public int Salary {
            get {
                return FieldSalary;
            }
            set {
                if (value <= 0) {
                    FieldSalary = 0;
                }
                else {
                    FieldSalary = value;
                }
            }
        }
        public Contacts Contacts {get; set;}
        public Passports Passports {get; set;}
    }
}
