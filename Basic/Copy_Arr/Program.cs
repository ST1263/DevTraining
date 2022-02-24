using System;

namespace Copy_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {10,20,30,40,50 };
            int[] arr1 = new int[5];
            int i;
            Console.WriteLine("Array 1:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
            Console.WriteLine("Array 2:");

            Array.Copy(arr, arr1, 5);
            foreach (int val in arr1)
            {

                Console.WriteLine(val + " ");
            }
        }
    }
}
