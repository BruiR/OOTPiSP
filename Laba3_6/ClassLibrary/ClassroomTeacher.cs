using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class ClassroomTeacher: Teacher
    {
        public string FieldGroup_number;
        public string Group_number{
            get {
                return FieldGroup_number;
            }
            set {
                if ((value.Length<2) || (value.Length>10)) {
                    FieldGroup_number = "error";
                }
                else {
                    FieldGroup_number = value;
                }
            }
        }

    }
}
