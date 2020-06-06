using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using SerializationLibrary;

namespace Object_Redactor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Type[] classes;
        private Type[] serializations;
        private Type[] plugins;
        private Assembly library;
        private Assembly slibrary;
        private Assembly plibrary;
        private List<object> listOfObjects;
        public Form1()
        {
            InitializeComponent();
            library = Assembly.LoadFrom("F:\\Ycheba\\4sem\\ООП\\Laba3_4\\ClassLibrary\\bin\\Debug\\ClassLibrary.dll");
            slibrary = Assembly.LoadFrom("F:\\Ycheba\\4sem\\ООП\\Laba3_4\\SerializationLibrary\\bin\\Debug\\SerializationLibrary.dll");
            plibrary = Assembly.LoadFrom("F:\\Ycheba\\4sem\\ООП\\Laba3_4\\PluginLibrary\\bin\\Debug\\PluginLibrary.dll");
            classes = library.GetTypes();
            plugins = plibrary.GetTypes();
            serializations = slibrary.GetTypes();
            listOfObjects = new List<object>();
            foreach (Type element in classes)
            {
                if ((element.IsClass) && (!element.IsAbstract))
                    Classes_comboBox.Items.Add(element.Name);
            }
            foreach (Type element in serializations)
            {
                if ((element.IsClass) && (!element.IsSealed)&& (!element.IsInterface))
                    Serialization_comboBox.Items.Add(element.Name);
            }
            foreach (Type element in plugins)
            {
                if ((element.IsClass) && (!element.IsSealed) && (!element.IsInterface))
                    Plugin_comboBox.Items.Add(element.Name);
            }
        }

        private void Classes_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info_flowLayoutPanel.Controls.Clear();
            var ClassName = Classes_comboBox.SelectedItem.ToString();
            foreach (var selectedClass in classes)
            {
                if (ClassName == selectedClass.Name)
                {
                    DrawProperties(selectedClass);
                    break;
                }
            }
        }

        private void DrawProperties(Type selectedClass)
        {
            var properties = selectedClass.GetProperties();
            foreach (var element in properties)
            {
                if ((element.PropertyType.IsPrimitive) || (element.PropertyType == typeof(String)))
                {
                    DrawLabel(element);
                    DrawTextBox(element);
                }
                else if (element.PropertyType.IsEnum)
                {
                    DrawLabel(element);
                    DrawComboBox(element);

                }
                else if (element.PropertyType == typeof(DateTime))
                {
                    DrawLabel(element);
                    DrawDateTimePicker(element);



                }
                else if (element.PropertyType.IsClass)
                {
                    DrawProperties(element.PropertyType);
                }

            }



        }
        private void DrawComboBox(PropertyInfo element)
        {
            ComboBox cmbBox = new ComboBox();
            cmbBox.Font = new Font("Calibri", 14, FontStyle.Regular);
            cmbBox.Width = 200;
            cmbBox.Visible = true;
            cmbBox.Name = element.Name + "_ComboBox";
            cmbBox.Text = "";
            foreach (var line in element.PropertyType.GetEnumNames())
                cmbBox.Items.Add(line);
            Info_flowLayoutPanel.Controls.Add(cmbBox);

        }
        private void DrawTextBox(PropertyInfo element)
        {
            TextBox txtBox = new TextBox();
            txtBox.Font = new Font("Calibri", 14, FontStyle.Regular);
            txtBox.Width = 200;
            txtBox.Visible = true;
            txtBox.Name = element.Name + "_TextBox";
            Info_flowLayoutPanel.Controls.Add(txtBox);

        }
        private void DrawLabel(PropertyInfo element)
        {
            Label lbl = new Label();
            lbl.Visible = true;
            lbl.Text = element.Name;
            lbl.Name = element.Name + "_Label";
            lbl.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            lbl.Width = 200;
            Info_flowLayoutPanel.Controls.Add(lbl);
        }
        private void DrawDateTimePicker(PropertyInfo element)
        {
            DateTimePicker dtPicker = new DateTimePicker();
            dtPicker.Visible = true;
            dtPicker.Width = 200;
            dtPicker.Name = element.Name + "_DateTimePicker";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "dd'.'MM'.'yyyy";
            Info_flowLayoutPanel.Controls.Add(dtPicker);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if ((Classes_comboBox.SelectedIndex != -1) && (Info_flowLayoutPanel.Controls.Count != 0))
            {
                var ClassName = Classes_comboBox.SelectedItem.ToString();
                foreach (var selectedClass in classes)
                {
                    if (ClassName == selectedClass.Name)
                    {
                        int i = 1;
                        var newObject = AddObject(selectedClass, ref i);
                        listOfObjects.Add(newObject);
                    }
                }
                DrawList();
                Info_flowLayoutPanel.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Choose class");
            }
        }


        private object AddObject(Type selectedClass, ref int i)
        {
            var newObject = Activator.CreateInstance(selectedClass);
            var properties = selectedClass.GetProperties();
            foreach (var element in properties)
            {
                if (element.PropertyType == typeof(int))
                {
                    try
                    {
                        TextBox tbx = (TextBox)Info_flowLayoutPanel.Controls[i];
                        element.SetValue(newObject, Int32.Parse(tbx.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect " + element.Name);
                    }
                    i += 2;
                }

                else if ((element.PropertyType == typeof(String)) || (element.PropertyType == typeof(char)))
                {
                    try
                    {
                        TextBox tbx = (TextBox)Info_flowLayoutPanel.Controls[i];
                        element.SetValue(newObject, tbx.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect " + element.Name);
                    }
                    i += 2;
                }

                else if (element.PropertyType.IsEnum)
                {
                    try
                    {
                        ComboBox cbx = (ComboBox)Info_flowLayoutPanel.Controls[i];
                        object en = element.PropertyType.GetEnumNames()[0];
                        foreach (string str in element.PropertyType.GetEnumNames())
                        {
                            if (cbx.SelectedItem.ToString() == str)
                                en = Enum.Parse(element.PropertyType, str);
                        }
                        element.SetValue(newObject, en);
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect " + element.Name);
                    }
                    i += 2;
                }

                else if (element.PropertyType == typeof(DateTime))
                {
                    try
                    {
                        DateTimePicker dtPicker = (DateTimePicker)Info_flowLayoutPanel.Controls[i];
                        element.SetValue(newObject, dtPicker.Value.Date);
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect " + element.Name);
                    }
                    i += 2;

                }
                else if (element.PropertyType.IsClass)
                {
                    var classproperty = AddObject(element.PropertyType, ref i);
                    element.SetValue(newObject, classproperty);
                }
            }

            return newObject;

        }
        private void DrawList()
        {
            InfoObjects_flowLayoutPanel.Controls.Clear();
            int i = 1;
            foreach (var ObjectElement in listOfObjects)
            {
                Label lbl = new Label();
                lbl.Visible = true;
                lbl.Text = ("№" + i.ToString() + " " + ObjectElement.GetType().Name);
                lbl.Name = ObjectElement.GetType().Name + "_Label";
                lbl.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lbl.Width = 550;
                InfoObjects_flowLayoutPanel.Controls.Add(lbl);
                DrawFields(ObjectElement);
                i++;
            }

        }
        private void DrawFields(object ObjectElement)
        {
            var properties = ObjectElement.GetType().GetProperties();

            foreach (var PropertyElement in properties)
            {
                if ((PropertyElement.PropertyType.IsClass) && (PropertyElement.PropertyType != typeof(String)))
                {
                    DrawFields(PropertyElement.GetValue(ObjectElement));
                }
                else
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Font = new Font("Calibri", 14, FontStyle.Regular);
                    txtBox.Width = 550;
                    txtBox.Visible = true;
                    txtBox.Enabled = false;
                    txtBox.Name = ObjectElement.GetType().Name + "_TextBox";
                    txtBox.Text += (PropertyElement.Name.ToString() + " = " + PropertyElement.GetValue(ObjectElement).ToString());
                    InfoObjects_flowLayoutPanel.Controls.Add(txtBox);
                }
            }
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            if (List_Number_textBox.Text.Length > 0)
            {
                try
                {
                    int number = Int32.Parse(List_Number_textBox.Text);
                    if ((number > 0) && (number < listOfObjects.Count + 1))
                    {
                        List_Number_textBox.Enabled = false;
                        Add_button.Visible = false;
                        Delete_button.Visible = false;
                        Modify_button.Visible = false;
                        Save_button.Visible = true;
                        Info_flowLayoutPanel.Controls.Clear();
                        object ModifyObject = listOfObjects[number - 1];
                        Classes_comboBox.Visible = false;
                        Classes_label.Visible = true;
                        Classes_label.Text = ModifyObject.GetType().Name.ToString();
                        DrawProperties(ModifyObject.GetType());
                        int i = 1;
                        DrawModifyProperties(ModifyObject, ref i);
                    }
                    else MessageBox.Show("Add correct number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
                }
                catch
                {
                    MessageBox.Show("Add correct number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
                }
            }
            else MessageBox.Show("Add  number. It might be 1 <= number<= " + listOfObjects.Count.ToString());

        }
        private void DrawModifyProperties(object ModifyObject, ref int i)
        {
            var properties = ModifyObject.GetType().GetProperties();
            foreach (var element in properties)
            {
                if (element.PropertyType == typeof(int))
                {
                    try
                    {
                        var value = element.GetValue(ModifyObject);
                        ((TextBox)Info_flowLayoutPanel.Controls[i]).Text = ((int)value).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect value of " + element.Name);
                    }
                    i += 2;

                }

                else if ((element.PropertyType == typeof(String)) || (element.PropertyType == typeof(char)))
                {
                    try
                    {
                        var value = element.GetValue(ModifyObject);
                        ((TextBox)Info_flowLayoutPanel.Controls[i]).Text = value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect value of " + element.Name);
                    }
                    i += 2;
                }

                else if (element.PropertyType.IsEnum)
                {
                    try
                    {
                        var value = element.GetValue(ModifyObject);

                        ((ComboBox)Info_flowLayoutPanel.Controls[i]).SelectedItem = value.ToString();
                    }
                    catch
                    { MessageBox.Show("Incorrect value of " + element.Name); }
                    i += 2;
                }
                else if (element.PropertyType == typeof(DateTime))
                {
                    try
                    {
                        var value = element.GetValue(ModifyObject);
                        ((DateTimePicker)Info_flowLayoutPanel.Controls[i]).Value = (DateTime)value;
                    }
                    catch
                    { MessageBox.Show("Incorrect value of " + element.Name); }
                    i += 2;
                }
                else if (element.PropertyType.IsClass)
                {
                    var clas = element.GetValue(ModifyObject);
                    DrawModifyProperties(clas, ref i);
                }

            }

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Modify_button.Visible = true;
            Classes_comboBox.Visible = true;
            Delete_button.Visible = true;
            Classes_label.Visible = false;
            Save_button.Visible = false;
            Add_button.Visible = true;
            if (List_Number_textBox.Text.Length > 0)
            {
                int number = Int32.Parse(List_Number_textBox.Text);
                if ((number > 0) && (number < listOfObjects.Count + 1))
                {
                    List_Number_textBox.Enabled = true;
                    int i = 1;
                    object ModifyObject = listOfObjects[number - 1];
                    var newObject = AddObject(ModifyObject.GetType(), ref i);
                    listOfObjects[number - 1] = newObject;
                    DrawList();
                    Info_flowLayoutPanel.Controls.Clear();
                }
                else MessageBox.Show("Add correct number. It might be 1 <= number<= " + listOfObjects.Count.ToString());

            }
            else MessageBox.Show("Add  number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (List_Number_textBox.Text.Length > 0)
            {
                try
                {
                    int number = Int32.Parse(List_Number_textBox.Text);
                    if ((number > 0) && (number < listOfObjects.Count + 1))
                    {
                        listOfObjects.RemoveAt(number - 1);
                        DrawList();
                    }
                    else MessageBox.Show("Add correct number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
                }
                catch
                {
                    MessageBox.Show("Add correct number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
                }
            }
            else MessageBox.Show("Add  number. It might be 1 <= number<= " + listOfObjects.Count.ToString());
        }


        private void Serialize_button_Click(object sender, EventArgs e)
        {
            if ((Serialization_comboBox.SelectedIndex != -1) && (Serialization_textBox.Text != ""))
            {
                var SerializationName = Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in serializations)
                {
                    if (SerializationName == element.Name)
                    {
                        var Serializator = Activator.CreateInstance(element);
                        string result = (string)Serializator.GetType().GetMethod("MakeSerialize").Invoke(Serializator, new object[] { listOfObjects, Serialization_textBox.Text });
                        if (result == "Success")
                        {
                            MessageBox.Show("Success serialization");
                            Serialization_textBox.Text = "";
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

        private void Deserialize_button_Click(object sender, EventArgs e)
        {
            if ((Serialization_comboBox.SelectedIndex != -1) && (Deserialization_textBox.Text != ""))
            {
                var DeserializationName = Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in serializations)
                {
                    if (DeserializationName == element.Name)
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        listOfObjects = (List<object>)Deserializator.GetType().GetMethod("MakeDeserialize").Invoke(Deserializator, new object[] { Deserialization_textBox.Text });
                        DrawList();
                        Deserialization_textBox.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose serialization and Deserialization filename");
            }
        }



        private void Serialization_filename_label_Click(object sender, EventArgs e)
        {
            if (Serialization_comboBox.SelectedIndex != -1)
            {
                var DeserializationName = Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in serializations)
                {
                    if (DeserializationName == element.Name)
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        var p = Deserializator.GetType().GetField("filters");
                        SaveFileDialog1.Filter = p.GetValue(p).ToString();                      
                        if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
                            return;
                        string filename = SaveFileDialog1.FileName;
                        Serialization_textBox.Text = filename;
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose serialization");
            }
        }

        private void Deserialization_filename_label_Click(object sender, EventArgs e)
        {
            if (Serialization_comboBox.SelectedIndex != -1)
            {
                var DeserializationName = Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in serializations)
                {
                    if (DeserializationName == element.Name)
                    {
                        var Deserializator = Activator.CreateInstance(element);                            
                        var p = Deserializator.GetType().GetField("filters");
                        OpenFileDialog1.Filter = p.GetValue(p).ToString();
                        if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
                            return;
                        string filename = OpenFileDialog1.FileName;
                        Deserialization_textBox.Text = filename;
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose serialization");
            }
        }

        private void Compressed_filename_label_Click(object sender, EventArgs e)
        {
            if (Plugin_comboBox.SelectedIndex != -1)
            {
                var PluginName = Plugin_comboBox.SelectedItem.ToString();
                foreach (var element in plugins)
                {
                    if (PluginName == element.Name)
                    {
                        var Compresser = Activator.CreateInstance(element);
                        var p = Compresser.GetType().GetField("filters");
                        SaveFileDialog1.Filter = p.GetValue(p).ToString();
                        if (SaveFileDialog1.ShowDialog() == DialogResult.Cancel)
                            return;
                        string filename = SaveFileDialog1.FileName;
                        Compress_textBox.Text = filename;
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose plugin");
            }
        }

        private void Decompressed_label_Click(object sender, EventArgs e)
        {
            string filter = "";
            foreach (var element in plugins)
            {
                if (!element.IsInterface)
                {
                    var Decompresser = Activator.CreateInstance(element);
                    var p = Decompresser.GetType().GetField("filters");
                    filter = filter + p.GetValue(p).ToString() + "|";
                }
            }
            if (filter.EndsWith("|"))
                filter = filter.Substring(0, filter.Length - 1);
            OpenFileDialog1.Filter = filter;
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog1.FileName;
            Decompress_textBox.Text = filename;
        }

        private void Compress_button_Click(object sender, EventArgs e)
        {
            if ((Serialization_comboBox.SelectedIndex != -1) && (Plugin_comboBox.SelectedIndex != -1) && (Compress_textBox.Text != ""))
            {
                var SerializationName = Serialization_comboBox.SelectedItem.ToString();
                foreach (var element in serializations)
                {
                    if (SerializationName == element.Name)
                    {
                        var Serializator = Activator.CreateInstance(element);
                        string filename = Compress_textBox.Text;
                        string zformat = "";
                        var PluginName = Plugin_comboBox.SelectedItem.ToString();
                        foreach (var plugin in plugins)
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

                        string result = (string)Serializator.GetType().GetMethod("MakeSerialize").Invoke(Serializator, new object[] { listOfObjects, filename });
                        if (result == "Success")
                        {
                            MessageBox.Show("Success serialization");

                            foreach (var plugin in plugins)
                            {
                                if (PluginName == plugin.Name)
                                {
                                    var Compresser = Activator.CreateInstance(plugin);
                                    Compresser.GetType().GetMethod("Compress").Invoke(Compresser, new object[] { filename });
                                    Compress_textBox.Text = "";
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

        private void Decompress_button_Click(object sender, EventArgs e)
        {
            string filename = Decompress_textBox.Text;
            string[] words = Decompress_textBox.Text.Split(new char[] { '.' });
            int n = words.Count();
            if (n >= 3)
            {

                string zformat = "." + words[n - 1];
                string sformat = "." + words[n - 2];
                foreach (var plugin in plugins)
                {
                    if ((!plugin.IsInterface)&& (plugin.IsClass))
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
                foreach (var element in serializations)
                {
                    if ((!element.IsInterface) && (element.IsClass) && (!element.IsSealed))
                    {
                        var Deserializator = Activator.CreateInstance(element);
                        var p = Deserializator.GetType().GetField("format");
                        string ssformat = p.GetValue(p).ToString();
                        if (ssformat == sformat)
                        {
                            listOfObjects = (List<object>)Deserializator.GetType().GetMethod("MakeDeserialize").Invoke(Deserializator, new object[] { filename.Substring(0, filename.Length-zformat.Length) });
                            DrawList();
                            Decompress_textBox.Text = "";
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
