using System;
using System.Collections;
using System.Collections.Generic;


namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, String> sl = new SortedList<int, string>();
            sl.Add(1, "B");
            sl.Add(2, "i");
            sl.Add(3, "z");
            sl.Add(4, "r");
            sl.Add(5, "u");
            sl.Add(6, "n");

            if (sl.ContainsValue("time")) 
            {
                sl.Add(7, "time");
            }
            IList<int> key = sl.Keys;

            foreach (var data in key) 
            {
                Console.Write(data+" ");
            }



           // LinkedList<string> lst = new LinkedList<string>();
           // lst.AddLast("Sahil ");
           // lst.AddFirst("am ");
           // lst.AddFirst("I ");
          
            
           //lst.RemoveFirst();
           // lst.RemoveLast();
           
            
           // foreach (var data in lst)
           // {
           //     Console.WriteLine(data);
           // }

              //ArrayList al = new ArrayList();
            //al.Add(3);
            //al.Add("Biz");
            //al.Add('x');
            //al.Add("string");
            //al.Add(5);

            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);
            //Console.WriteLine(al[1]);
            //al.RemoveAt(0);
            //for (int i = 0; i < al.Count; i++) 
            //{ Console.WriteLine(al[i]); }

        }
    }
}
