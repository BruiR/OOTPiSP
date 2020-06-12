using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Redactor
{
    class SerializeHelper
    {
        Form1 form1;
        public SerializeHelper(Form1 f1)
        {
            form1 = f1;
        }

        public void StartSerialize()
        {
            if ((form1.Serialization_comboBox.SelectedIndex != -1) && (form1.Serialization_textBox.Text != ""))
            {
                var SerializationName = form1.Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in form1.serializations)
                {
                    if (SerializationName == element.Name)
                    {
                        var Serializator = Activator.CreateInstance(element);
                        string result = (string)Serializator.GetType().GetMethod("MakeSerialize").Invoke(Serializator, new object[] { form1.listOfObjects, form1.Serialization_textBox.Text });
                        if (result == "Success")
                        {
                            MessageBox.Show("Success serialization");
                            form1.Serialization_textBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error of serialization " + result);
                        }
                    }
                }
                foreach (var element in form1.adapters)
                {
                    if (SerializationName == element.Name)
                    {
                        var Serializator = Activator.CreateInstance(element);
                        string result = (string)Serializator.GetType().GetMethod("MakeSerialize").Invoke(Serializator, new object[] { form1.listOfObjects, form1.Serialization_textBox.Text });
                        if (result == "Success")
                        {
                            MessageBox.Show("Success serialization");
                            form1.Serialization_textBox.Text = "";
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
                MessageBox.Show("Choose serialization and Serialization filename");
            }
        }
        public void StartDeserialize()
        {
            if ((form1.Serialization_comboBox.SelectedIndex != -1) && (form1.Deserialization_textBox.Text != ""))
            {
                var DeserializationName = form1.Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in form1.serializations)
                {
                    if (DeserializationName == element.Name)
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        form1.listOfObjects = (List<object>)Deserializator.GetType().GetMethod("MakeDeserialize").Invoke(Deserializator, new object[] { form1.Deserialization_textBox.Text });
                        form1.DrawList();
                        form1.Deserialization_textBox.Text = "";
                    }
                }
                foreach (var element in form1.adapters)
                {
                    if (DeserializationName == element.Name)
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        form1.listOfObjects = (List<object>)Deserializator.GetType().GetMethod("MakeDeserialize").Invoke(Deserializator, new object[] { form1.Deserialization_textBox.Text });
                        form1.DrawList();
                        form1.Deserialization_textBox.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose serialization and Deserialization filename");
            }
        }
    }
}
