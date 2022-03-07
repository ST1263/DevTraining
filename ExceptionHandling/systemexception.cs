using System;

namespace sytemexception
{
    class Program
    {
        static void Main(string[] args)
        {

            object obj = new Object();
            int i;
            try
            {
                i = (int)obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
