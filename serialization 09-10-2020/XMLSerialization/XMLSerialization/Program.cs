using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName = "sk", LastName = "sahil" };
            string filepath = @"E:\xmlsahil";
            XMLserialization xml = new XMLserialization();
            xml.XMLSerialize(typeof(Person),person,filepath);
            Person p = xml.XMLDeSerialize(typeof(Person), filepath) as Person;
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
        }
    }


    class XMLserialization
    {
        public void XMLSerialize(Type dataType, object data, string filepath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filepath)) File.Delete(filepath);
            TextWriter writer = new StreamWriter(filepath);
            xmlSerializer.Serialize(writer, data);
            writer.Close();
        }

        public object XMLDeSerialize(Type dataType, string filepath) 
        {
            object obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filepath)) 
            {
                TextReader textReader = new StreamReader(filepath);
                obj = xmlSerializer.Deserialize(textReader);
                textReader.Close();
            }

                return obj;
        }   

        
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
