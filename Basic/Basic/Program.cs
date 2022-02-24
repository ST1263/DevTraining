using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5] {20,10,50,30,40};
            int i;
            Console.WriteLine("Before Sorting Elements:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} ", Arr[i]);
            }
            Console.WriteLine("After Sorting Elements:");
            Array.Sort(Arr);
            foreach (int val in Arr)
            {
                
                Console.WriteLine(val + " ");
            }
            
        }
    }
}
