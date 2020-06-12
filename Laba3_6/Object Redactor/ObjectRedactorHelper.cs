using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Redactor
{
    class ObjectRedactorHelper
    {
        CompressHelper comprHelper;
        SerializeHelper serHelper;
        Form1 form1;

        public ObjectRedactorHelper(Form1 f1) 
        {
            form1 = f1;
            comprHelper = new CompressHelper(f1);
            serHelper = new SerializeHelper(f1);
        }

        public void CompresClick()
        {
            comprHelper.StartCompress();
        }
        public void DecompresClick()
        {
            comprHelper.StartDecompres();
        }


        public void DeserializeClick()
        {
            serHelper.StartDeserialize();
        }

        public void SerializeClick()
        {
            serHelper.StartSerialize();
        }


    }
}
