using System;
using System.Collections;
using System.Text;

namespace CollectionsAndGenerics
{
    class HashTables
    {
        public void HashtaleMethods()
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "sahil");
            ht.Add("org", "bizrun");
            ht.Add("domain", "Software engg");
            ht.Add("id", "xyz");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }

        }
    }
}
