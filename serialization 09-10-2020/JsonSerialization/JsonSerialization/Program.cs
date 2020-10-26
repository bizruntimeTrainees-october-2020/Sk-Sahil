using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName = "SK", LastName = "SAHIL" };
            string filePath = @"E:\sahilJSON";
            JSONSerializationAndDeserialization jSON
                = new JSONSerializationAndDeserialization();
            jSON.JsonSerialize(person, filePath);
            Person p = jSON.JsonDeserialize(typeof(Person), filePath) as Person;
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            
        }
    }

    class JSONSerializationAndDeserialization
    {
        public void JsonSerialize(object data, string filepath) 
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filepath)) File.Delete(filepath);
            StreamWriter sw = new StreamWriter(filepath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);
            jsonSerializer.Serialize(jsonWriter, data);
            jsonWriter.Close();
            sw.Close();

        }

        public object JsonDeserialize(Type DataType ,string filepath) 
        {
           JObject jobj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filepath)) 
            {
                StreamReader streamReader = new StreamReader(filepath);
                JsonReader jsonReader = new JsonTextReader(streamReader);
                jobj = jsonSerializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                streamReader.Close();
            
            } 
            
            return jobj.ToObject(DataType);
        }

    }

    public class Person 
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
