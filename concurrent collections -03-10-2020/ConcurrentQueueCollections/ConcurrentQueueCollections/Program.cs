﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueueCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();
            for (int i = 0; i < 10000; i++)
            {
                cq.Enqueue(i);
            }

            int result;
            if (!cq.TryPeek(out result))
            {
                Console.WriteLine("CQ: TryPeek() method failed..!!!");
            }
            else if (result != 0)
            {
                Console.WriteLine("CQ: Expected TryPeek result of 0, got {0}", result);
            }
            int outerSum = 0;
            Action action = () =>
            {
                int localSum = 0;
                int localValue;
                while (cq.TryDequeue(out localValue)) localSum += localValue;
                Interlocked.Add(ref outerSum, localSum);
            };
            Parallel.Invoke(action, action, action, action);

            Console.WriteLine("outerSum = {0}, should be 49995000", outerSum);
        }
    }
}
