using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static JSON.NET.MyObjectClass;

namespace JSON.NET
{
    class SerializeAndDeSerializationOfAClass 
    {
        public void SerializeAndDeSerializationMethod() 
        {
            Console.WriteLine("\nSerialization");
            Movie m = new Movie() { Name = "Civil War", Rating = 9.6 };
            string result = JsonConvert.SerializeObject(m);
            Console.WriteLine(result);


            Console.WriteLine("\nDeSerialization");

            Movie afterDeSerialize = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("Name of The Movie is : " + afterDeSerialize.Name);
            Console.WriteLine("Rating of The Movie is : " + afterDeSerialize.Rating);

        }
    }
}
