using System;
using System.Collections;
using System.Text;

namespace Array
{
    class ArrayLists
    {
        public void ArraylistClass()
        {
           
            ArrayList al = new ArrayList();
            al.Add(1); al.Add(2); al.Add(3); al.Add(4);
            Console.WriteLine(al.Capacity);
            al.Add(5);
            Console.WriteLine(al.Capacity);
            Console.WriteLine(al.Count);
            al.Insert(5, 6);
            al.Remove(5);
            al.RemoveAt(al.Count - 1);

            foreach (object data in al)
            {
                Console.Write(data + " ");

            }
        }
    }
}
