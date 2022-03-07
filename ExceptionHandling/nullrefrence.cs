using System;

namespace nullrefrence
{
    class nullrefrence
    {
        static void Main(string[] args)
        {

            string s = null;
            try
            {

                if (s.Length == 0)
                {
                    Console.WriteLine(s);
                }
      

            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
