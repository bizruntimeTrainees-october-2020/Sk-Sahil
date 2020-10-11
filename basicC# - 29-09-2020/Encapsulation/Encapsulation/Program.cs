using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GeekyBoy gb = new GeekyBoy();
            gb.Name = "Sahil";
            gb.Age = 23;
            Console.WriteLine("i am  " + gb.Name + " and my age is " + gb.Age);
        }
    }

    public class GeekyBoy
    {
        private String name;   // called fields 
        private int age;

        public String Name // called property
        {
            get { return name; }
            set { name = value; }
        }  
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }



    }
}
