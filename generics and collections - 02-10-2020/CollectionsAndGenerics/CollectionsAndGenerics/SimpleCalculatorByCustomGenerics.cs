using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndGenerics
{
    class SimpleCalculatorByCustomGenerics
    {
        public void SimpleCalculatorByCustomGenericsMethod() 
        {


            GenericCalculator gen = new GenericCalculator();
            gen.add<int>(10, 20);
            gen.subs<float>(30.5f, 10.9f);
            gen.mul<double>(20.00, 40.45);
            gen.div<byte>(2, 4);
        }
    }
    class GenericCalculator

    {
        public void add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void subs<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mul<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
}
