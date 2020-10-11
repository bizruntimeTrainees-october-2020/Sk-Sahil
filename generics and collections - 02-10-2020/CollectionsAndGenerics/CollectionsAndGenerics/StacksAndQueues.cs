using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CollectionsAndGenerics
{
    class StacksAndQueues
    {
        public void QueueMethods()
        {
            Queue queue = new Queue();
            queue.Enqueue(1); queue.Enqueue(2); queue.Enqueue(3); queue.Enqueue(4);
            foreach (var i in queue)
            {
                Console.Write(i + " ");

            }
            queue.Dequeue();
            Console.WriteLine();
            foreach (var i in queue)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            Console.WriteLine(queue.Peek());

            IEnumerator ie = queue.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.Write(ie.Current + " ");
            }

            Console.WriteLine();





        }
        public void StackMethods()
        {
            Stack stk = new Stack();
            stk.Push(1); stk.Push(2); stk.Push(3); stk.Push(4); stk.Push(5);
            stk.Pop();
            foreach (var i in stk) 
            {
                Console.Write(i+" " );
            }


        }
    }
}
