using System;
using System.Collections;

namespace ArrList
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(15);
            al.Add(50);
            Console.WriteLine("Adding Element");
            foreach (int val in al)
            {
                Console.WriteLine(val);
            }
            al.Insert(1, 15);
            Console.WriteLine("Insert Element");
            foreach (int val in al)
            {
                Console.WriteLine(val);
            }
            al.RemoveAt(2);
            Console.WriteLine("RemoveAT Element");
            foreach (int val in al)
            {
                Console.WriteLine(val);
            }
            al.Remove(50);
            Console.WriteLine("Remove Element");
            foreach (int val in al)
            {
                Console.WriteLine(val);
            }
            t = al.Count;
            Console.WriteLine("Total Count:=" +t);
        }
    }
}