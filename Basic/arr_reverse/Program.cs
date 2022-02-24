using System;

namespace arr_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5] { 20, 10, 50, 30, 40 };
            int i;
            Console.WriteLine("Before Reverse Elements:");
            for (i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} ", Arr[i]);
            }
            Console.WriteLine("After Reverse Elements:");
            Array.Reverse(Arr);
            foreach (int val in Arr)
            {

                Console.WriteLine(val + " ");
            }
        }
    }
}
