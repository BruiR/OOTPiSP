using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Redactor
{
    class CompressHelper
    {
        Form1 form1;
        public CompressHelper(Form1 f1) 
        {
            form1 = f1;
        }
        public void StartCompress() 
        {
            if ((form1.Serialization_comboBox.SelectedIndex != -1) && (form1.Plugin_comboBox.SelectedIndex != -1) && (form1.Compress_textBox.Text != ""))
            {
                var SerializationName = form1.Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in form1.serializations)
                {
                    if (SerializationName == element.Name)
                    {
                        var Serializator = Activator.CreateInstance(element);
                        string filename = form1.Compress_textBox.Text;
                        string zformat = "";
                        var PluginName = form1.Plugin_comboBox.SelectedItem.ToString();
                        foreach (var plugin in form1.plugins)
                        {
                            if (PluginName == plugin.Name)
                            {
                                var Compresser = Activator.CreateInstance(plugin);
                                var p = Compresser.GetType().GetField("format");
                                zformat = p.GetValue(p).ToString();
                            }
                        }
                        filename = filename.Substring(0, filename.Length - zformat.Length);
                        string sformat = "";
                        var s = Serializator.GetType().GetField("format");
                        sformat = s.GetValue(s).ToString();
                        filename = filename + sformat;

                        string result = (string)Serializator.GetType().GetMethod("MakeSerialize").Invoke(Serializator, new object[] { form1.listOfObjects, filename });
                        if (result == "Success")
                        {
                            MessageBox.Show("Success serialization");

                            foreach (var plugin in form1.plugins)
                            {
                                if (PluginName == plugin.Name)
                                {
                                    var Compresser = Activator.CreateInstance(plugin);
                                    Compresser.GetType().GetMethod("Compress").Invoke(Compresser, new object[] { filename });
                                    form1.Compress_textBox.Text = "";
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error of serialization " + result);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose serialization and plugin, Serialization and Compressed filename");
            }
        }

        public void StartDecompres()
        {
            string filename = form1.Decompress_textBox.Text;
            string[] words = form1.Decompress_textBox.Text.Split(new char[] { '.' });
            int n = words.Count();
            if (n >= 3)
            {

                string zformat = "." + words[n - 1];
                string sformat = "." + words[n - 2];
                foreach (var plugin in form1.plugins)
                {
                    if ((!plugin.IsInterface) && (plugin.IsClass))
                    {
                        var Decompresser = Activator.CreateInstance(plugin);
                        var p = Decompresser.GetType().GetField("format");
                        string zzformat = p.GetValue(p).ToString();
                        if (zzformat == zformat)
                        {
                            MessageBox.Show(Decompresser.GetType().GetMethod("Decompress").Invoke(Decompresser, new object[] { filename }).ToString());
                        }
                    }
                }
                foreach (var element in form1.serializations)
                {
                    if ((!element.IsInterface) && (element.IsClass) && (!element.IsSealed))
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        var p = Deserializator.GetType().GetField("format");
                        string ssformat = p.GetValue(p).ToString();
                        if (ssformat == sformat)
                        {
                            form1.listOfObjects = (List<object>)Deserializator.GetType().GetMethod("MakeDeserialize").Invoke(Deserializator, new object[] { filename.Substring(0, filename.Length - zformat.Length) });
                            form1.DrawList();
                            form1.Decompress_textBox.Text = "";
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Incorrect file");
            }
        }
    }
}
