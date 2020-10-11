using System;

namespace ConcurrentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcurrentBagCollecction concurrentBagCollecction = new ConcurrentBagCollecction();
            //concurrentBagCollecction.AddingAndRemovingItems();


            ConCurrentDictionaryCollections dict = new ConCurrentDictionaryCollections();
            dict.ConcuurrentDictionaryMethod();

        }
    }
}
