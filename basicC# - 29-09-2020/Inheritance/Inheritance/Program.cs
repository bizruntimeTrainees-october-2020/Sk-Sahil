using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.m2();
            c.m1();
           
          
        }
    }

    class Parent 
    {
        public void m1() 
        {
            Console.WriteLine("This is parent class");
        }
    }
    class Child : Parent,Parent2
    {
        public void m2() 
        {
            Console.WriteLine("This is chid class");
        }
    }

    class Parent2 { }
}
