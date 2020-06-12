using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    sealed public class Passports
    {
        public string FieldName;
        public string Name{
            get
            {
                return FieldName;
            }
            set
            {
                if ((value.Length==0)|| (value.Length > 20))
                {
                    FieldName = "error";
                }
                else
                {
                    FieldName = value;
                }
            }
        }
        public string FiledSurname;
        public string Surname{
            get
            {
                return FiledSurname;
            }
            set
            {
                if ((value.Length == 0)|| (value.Length>20))
                {
                    FiledSurname = "error";
                }
                else
                {
                    FiledSurname = value;
                }
            }
        }
        public DateTime FieldDate_of_birth;
        public DateTime Date_of_birth{ get; set; }

    }
}
