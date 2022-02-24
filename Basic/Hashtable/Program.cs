using System;
using System.Collections;

namespace Hashtable1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "Shreyas");
            h.Add(2, "Tamboli");
            h.Add(3, "Rohit");
            foreach (DictionaryEntry v in h)
            {
                Console.WriteLine("Key {0} and Value {1} ", v.Key, v.Value);
            }
            h.Remove(3);
   
            foreach (DictionaryEntry v in h)
            {
                Console.WriteLine("{0} and {1} ", v.Key, v.Value);
            }
            Console.WriteLine(h.ContainsKey(3));
            Console.WriteLine(h.ContainsValue("Tamboli"));
            h.Clear();
            foreach (DictionaryEntry v in h)
            {
                Console.WriteLine("{0} and {1} ", v.Key, v.Value);
            }
            int t = h.Count;
            Console.WriteLine("Total Count:=" + t);
           







        }
    }
}
