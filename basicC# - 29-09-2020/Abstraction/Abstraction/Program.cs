using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AreaOfCircle aoc = new AreaOfCircle();
            Console.WriteLine("Area of circle is "+aoc.area(3));
            Console.WriteLine("parametere of circle is "+aoc.parametere(3));
        }
    }


    public abstract class Circle 
    {
        public abstract double area(int rad);
        public double parametere(int radious ) 
        {
            return 2 * Math.PI * radious;
        }
    }

    public class AreaOfCircle : Circle 
    {
        public override double area(int r) 
        {
            return Math.PI * r * r;
        }
    }
}
