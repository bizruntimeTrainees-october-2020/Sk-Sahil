using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace JSON.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeAndDeSerializationOfAClass serializeAndDeserialize = new SerializeAndDeSerializationOfAClass();
            serializeAndDeserialize.SerializeAndDeSerializationMethod();


        }
    }


   
}
