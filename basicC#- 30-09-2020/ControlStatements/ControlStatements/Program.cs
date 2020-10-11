using System;


namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter elements");
            for(int i = 0; i < n; i++) 
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = Int32.MinValue;


            //for (; ; )
            //{
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //    }
            //}


            foreach (var element in a)
            {
                if (element > max)
                {
                    max = element;
                }
            }

            //--------while loop

            //int j = 0;
            //while (j < a.Length) 
            //{
            //    if (a[j] > max) 
            //    {
            //        max = a[j];

            //    }
            //    j++;
            //}

            Console.WriteLine("The max value of the arrray is " + max); 
          

          




        }
    }
}
