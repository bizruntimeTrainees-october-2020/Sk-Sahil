using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndGenerics
{
    class InbuiltGenerics
    {
        public void InbuiltGenericsMethods() 
        {
            List<int> li = new List<int>();
            li.Add(1); li.Add(2); li.Add(3);
            foreach (int i in li)
            {
                Console.Write(i + " ");
            }
        }
}
}
