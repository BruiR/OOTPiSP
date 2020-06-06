using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    sealed public class Contacts
    {
        public string FieldEmail;
        public string Email{
            get
            {
                return FieldEmail;
            }
            set
            {
                if (value == "")
                {
                    FieldEmail = "error";
                }
                else
                {
                    FieldEmail = value;
                }
            }
        }

        public string FieldPhone;
        public string Phone{
            get
            {
                return FieldPhone;
            }
            set
            {
                if ((value.Length==0)|| (value.Length>8))
                {
                    FieldPhone = "error";
                }
                else
                {
                    FieldPhone = value;
                }
            }
        }
    }
}
