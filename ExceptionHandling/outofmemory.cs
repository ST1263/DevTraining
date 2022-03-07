using System;
using System.Text;

namespace outofmemory
{
    class outofmemory
    {
        static void Main(string[] args)
        {
           
                StringBuilder sb = new StringBuilder(15, 15);
                sb.Append("out memory  ");
                try
                {

                sb.Insert(0, "Substring  ", 1);
                }
                catch (OutOfMemoryException e)
                {
                    Console.WriteLine(e.Message);
                }
           
        }
    }
}
