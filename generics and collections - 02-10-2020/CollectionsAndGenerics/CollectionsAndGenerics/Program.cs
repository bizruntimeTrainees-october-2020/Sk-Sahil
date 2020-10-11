using System;
using System.Collections;
using System.Collections.Generic;
using Array;


namespace CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylist
            ArrayLists Al = new ArrayLists();
            Al.ArraylistClass();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //hash table

            HashTables Htabs = new HashTables();
            Htabs.HashtaleMethods();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //generics
            InbuiltGenerics ibgs = new InbuiltGenerics();
            ibgs.InbuiltGenericsMethods();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //custom generics

            CustomTypeGenerics ctg = new CustomTypeGenerics();
            ctg.CustomTypeGenericsMethod();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();


            //custom generics calculator

            SimpleCalculatorByCustomGenerics simpleCalculator = new SimpleCalculatorByCustomGenerics();
            simpleCalculator.SimpleCalculatorByCustomGenericsMethod();
            
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            //stacks and queues

            StacksAndQueues stkandqueue = new StacksAndQueues();
            stkandqueue.QueueMethods();
            stkandqueue.StackMethods();








        }
    }
}
    

   
