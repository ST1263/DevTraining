using System;
using System.IO;

namespace ExceptionHandling
{
    class ioexception
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream("E:\\file.txt", FileMode.Open);
          
            }
            
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
