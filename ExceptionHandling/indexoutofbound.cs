using System;

namespace indexoutofbound
{
    class indexoutofbound
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 5, 10, 15 };
            try
            { 
                for (int j = 0; j < arr.Length; j++)
                {

                    Console.WriteLine(arr[4]);

                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
