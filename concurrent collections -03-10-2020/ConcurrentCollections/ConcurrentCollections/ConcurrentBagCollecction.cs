using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    class ConcurrentBagCollecction
    {
        public void AddingAndRemovingItems()
        {
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            List<Task> bagAddtask = new List<Task>();
            for (int i = 0; i < 500; i++)
            {
                var numToAdd = i;
                bagAddtask.Add(Task.Run(() => cb.Add(numToAdd)));

            }
            Task.WaitAll(bagAddtask.ToArray());


            List<Task> bagConsumeTask = new List<Task>();
            int itemsInBag = 0;
            while (!cb.IsEmpty) 
            {
                bagConsumeTask.Add(Task.Run(() =>
                {
                    int item;
                    if (cb.TryTake(out item)) 
                    {
                        Console.WriteLine(item);
                        itemsInBag++;
                    }
                }


                )); 
            }

            Task.WaitAll(bagConsumeTask.ToArray());

            Console.WriteLine($"There were {itemsInBag} items in the bag");
            int unexpectedItem;
            if (cb.TryPeek(out unexpectedItem))
                Console.WriteLine("Found an item in the bag when it should be empty");


        }
    }
}
