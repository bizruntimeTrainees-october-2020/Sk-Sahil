using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class LinqFunctions
    {
        public void LinqFunctionMethods() 
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Count());
            double d = list.Aggregate((a, b) => a + b);
            Console.WriteLine(d);
        }
    }
}
