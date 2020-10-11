using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentCollections
{
    class ConCurrentDictionaryCollections

    {
        public void ConcuurrentDictionaryMethod() 
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            
            t1.Start();
            t2.Start();

            
        }

        ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

        public void M1() 
        {
            for (int i = 0; i < 100; i++) 
            {
                dictionary.TryAdd(i, "M1 added : "+i);
                Console.WriteLine(i+ ": M1-->"+i);
            }
        }public void M2() 
        {
            for (int i = 0; i < 100; i++) 
            {
                dictionary.TryAdd(i, "M2 added : "+i);
                Console.WriteLine(i + ": M2-->" + i);
            }
        }
    }
}
