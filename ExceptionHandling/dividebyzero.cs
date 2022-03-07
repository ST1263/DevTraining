using System;

namespace dividebyzero
{
    class dividebyzero
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 0;
                int result = 100 / num;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
