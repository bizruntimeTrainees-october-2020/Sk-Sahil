using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JSONSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Person person = new Person() { FirstName="BizRun", LastName = "Time" };
                string filepath = @"E:\ORganization.txt";

                DataSerializer dataSerializer = new DataSerializer();
                
                dataSerializer.BinarySerialize(person, filepath);

          Person  p = dataSerializer.BinaryDeserialize(filepath) as Person;

                Console.WriteLine(p.FirstName);
                Console.WriteLine(p.LastName);

            }
        
        }
    }

    class DataSerializer 
    {
        public void BinarySerialize(object data, string filepath) 
        {


        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filepath)) File.Delete(filepath);
            FileStream fileStream = File.Create(filepath);
            bf.Serialize(fileStream,data);
            fileStream.Close();
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
            
        }
        }

        public object BinaryDeserialize(string filepath) 
        {
            object obj = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filepath))
            {
                    FileStream filestream = File.OpenRead(filepath);
                    obj = bf.Deserialize(filestream);
                    filestream.Close();
            
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
         
        }
            return obj;
        }


    }

    [Serializable]
    public class Person 
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

      
    }

