using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           bool f=Convert.ToBoolean( Console.ReadLine());
            Bike b = new Bike();
            b.color();
            b.modelName();
            b.noOfWheel();
            b.speed();
            b.isUseFuel(f);

        }
    }


   public  interface Vehicle1
    {
        public void modelName();
        public void speed();
        public  void color();
    }
    public interface Vehicle2
    {
        public void noOfWheel();
       public void isUseFuel(bool f);
    }

    public class  Bike : Vehicle1,Vehicle2
    {
        public void modelName() { Console.WriteLine("Royal Enfield"); }
        public void speed() { Console.WriteLine("50kmph"); }
        public void color() { Console.WriteLine("Red and Black"); }
        public void noOfWheel() { Console.WriteLine(" 2 Wheeler"); }
       public  void isUseFuel(bool f)
        {
            if (f)
            {
                Console.WriteLine("Yes it used fuel");
                
            }
            else 
            {
                Console.WriteLine("No it dont use fuel");
            }
        }
    }
    

}
