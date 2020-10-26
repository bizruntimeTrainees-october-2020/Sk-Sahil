using System;

namespace ExceptionHandlings
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            try
            {
               // a = a / b;
                var entry = int.Parse(Console.ReadLine());

            }
            catch (ArgumentNullException ane)
            {
                throw ane;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.GetType().FullName);
                Console.WriteLine(dbze.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().FullName);
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("code is done!");
            }
        }
    }

    

}
