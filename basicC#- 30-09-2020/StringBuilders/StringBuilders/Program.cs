using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Biz");
            sb.Append("Runtime");
            sb.Insert(3,"Hi");
            //sb.Remove(3,2);
            sb.Replace("Hi", "");
            Console.WriteLine(sb);


        }
    }
}
