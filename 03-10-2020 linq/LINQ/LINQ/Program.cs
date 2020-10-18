using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
   
    class Program
    {
        static void Main(string[] args)
        {

              List<int> li = new List<int>() {0,1,2,3,4,5,6,7,8,9 };

            //Query syntax
            var Qsyntax = from fetch in li where fetch < 5 select fetch;
            foreach (var items in Qsyntax) 
            {
                Console.Write(items + " ");
            }

            Console.WriteLine();
            
            //method syntax

            var methodSyntax = li.Where(obj => obj >5 && obj<9 ).ToList();
            foreach(var item in methodSyntax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //mixed syntax

            var mixedSyntax = (from mydata in li where mydata > 3 select mydata).ToList();

            foreach (var i in mixedSyntax) {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            //linq func

            LINQ.LinqFunctions linqf = new LINQ.LinqFunctions();
            linqf.LinqFunctionMethods();
            Console.WriteLine();

            //linq operators
            LINQ.LinqOperators linqOperators = new LinqOperators();
            linqOperators.LinqOperatorMethods();
            Console.WriteLine();

            //linq sorting operators

            LinqSortingOperator lsop = new LinqSortingOperator();
            lsop.SortingOperatrors(); 
            Console.WriteLine();


        }
    }
}
