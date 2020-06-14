using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SerializationLibrary
{
    class TextSerialization
    {
        static Assembly library;
        static List<Type> classes = new List<Type>();
        public const string filters = "текстовый файл (*.txt)|*.txt";
        public const string format = ".txt";
        private static void AddToFileProperties(object selectedObject, StreamWriter f)
        {
            var properties = selectedObject.GetType().GetProperties();
            foreach (var element in properties)
            {
                f.WriteLine("             " + element.Name + ": " + element.GetValue(selectedObject));
                if ((element.PropertyType.IsClass)
                    && (element.PropertyType != typeof(String)))
                {
                    AddToFileProperties(element.GetValue(selectedObject), f);
                }
            }
        }


        private static object AddFromFileProperties(Type selectedClass, StreamReader f)
        {
            var obj = library.CreateInstance(selectedClass.FullName);
            var properties = selectedClass.GetProperties();
            foreach (var element in properties)
            {
                string info = f.ReadLine();
                string value = info.Substring(13 + element.Name.Length + ": ".Length);
                if (element.PropertyType == typeof(int))
                { 
                        element.SetValue(obj, Int32.Parse(value));
                }

                else if (element.PropertyType == typeof(String))
                {
                        element.SetValue(obj, value);
                }

                else if (element.PropertyType == typeof(char))
                {
                        element.SetValue(obj, value[0]);
                }


                else if (element.PropertyType.IsEnum)
                {
                    object en = element.PropertyType.GetEnumNames()[0];
                    foreach (string str in element.PropertyType.GetEnumNames())
                    {
                        if (str == value)
                            en = Enum.Parse(element.PropertyType, str);
                    }
                    element.SetValue(obj, en);
                }

                else if (element.PropertyType.IsClass)
                {
                    var agreg = AddFromFileProperties(element.PropertyType, f);
                    element.SetValue(obj, agreg);
                }

            }

            return obj;

        }




        public string ToSerialize(List<object> School_workers, string fileName)
        {
            try
            {
                using (StreamWriter f = new StreamWriter(fileName, false, System.Text.Encoding.Default))
                {
                    foreach (var element in School_workers)
                    {
                        string objectType = element.GetType().FullName;
                        f.WriteLine("Object: " + objectType);
                        AddToFileProperties(element, f);
                    }

                }
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<object> ToDeserialize(string fileName)
        {
            library = Assembly.LoadFrom("D:\\Рабочий_стол\\ООП\\3 lab\\Object Redactor\\ClassLibrary\\bin\\Debug\\ClassLibrary.dll");
            classes = library.GetTypes().Where(type => type.IsClass).ToList();
            List<object> selectedObjects = new List<object>();
            using (StreamReader f = new StreamReader(fileName))
            {
                while (!f.EndOfStream)
                {
                    string info = f.ReadLine();

                    if (info.Contains("Object: "))
                    {
                        info = info.Substring(8);
                        IEnumerable<Type> objectType = classes.Where<Type>(tp => tp.FullName == info);
                        object School_worker = AddFromFileProperties(objectType.ToList()[0],f);
                        selectedObjects.Add(School_worker);
                    }
                }
            }
            return selectedObjects;
        }
    }
}
