using System;
namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            Console.WriteLine("Enter temperature");
            var temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("wait....");
            try
            {
                temp.CheckingTemperature(temperature);

            }
            catch (TemperatureIsZeroException tize) 
            {
                Console.WriteLine("Temperature is Zero :{0}", tize.Message);
            }
            
        }
    }
    class TemperatureIsZeroException : Exception 
    {
        public TemperatureIsZeroException (String message) : base(message) 
        {
        }
    }
   class Temperature 
    {
       
        public void CheckingTemperature( int t) 
        {
            if (t == 0)
            {
                throw new TemperatureIsZeroException("TemperatureIsZeroException Occured !");
            }
            else
            {
                Console.WriteLine("Temperature is : {0}", t);
            }
        }
    }
}
