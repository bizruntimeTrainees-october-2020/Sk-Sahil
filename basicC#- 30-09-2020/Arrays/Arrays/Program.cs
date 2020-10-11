using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D Array

            
            //arr = new int[] { 1, 2, 3, 4, 5 };

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}



            //2D Array

            int[,] a = new int[2, 2];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }


            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(i); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();


            }


            //Array class

            //int[] arr = new int[5] { 1, 2, 3, 4,5 };
            //Console.WriteLine(arr.IsFixedSize);  //True
            //Console.WriteLine(arr.IsReadOnly);    // false
            // Console.WriteLine(arr.Rank);   //gives dimension
            // Console.WriteLine(arr.Length);  //
            //Console.WriteLine(arr.LongLength);
            //Console.WriteLine(Array.BinarySearch(arr,3));
            //Array.Clear(arr, 1, 3);
            //int[] br = new int[5];



            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}



        }
    }
}
