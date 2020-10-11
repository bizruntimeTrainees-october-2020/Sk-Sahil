using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane p = new Plane();
            Plane fp = new FighterPlane();
            //Plane cp = new CargoPlane();
            //p.fly();
            fp.fly();
            //cp.fly();


            //overloading-----------

            Addition a = new Addition();

        

            //double t=a.Add(2.3, 4.5);
            //double t=a.Add(2, 3.2, 5.5);
            Console.WriteLine(a.Add(2, 3));



        }
    }


    public class Addition 
    {
        public int Add(int a, int b) 
        {
            return a + b;

        }

        public double Add(double a, double b)
        {
            return a + b;

        }

        public double Add(int a,double b,double c)
        {
            return a+b+c;

        }


    }



    public class Plane
    {
        public virtual void fly() 
        {
            Console.WriteLine("plane can fly");
        }
    }

    public class FighterPlane : Plane
    {
        public override void fly()
        {
            Console.WriteLine("FighterPlane do fights also");
        }
    }

    public class CargoPlane : Plane
    {
        public override void fly()
        {
            Console.WriteLine("CargoPlane carries goods also");
        }
    }
}
