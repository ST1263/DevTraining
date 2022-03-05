using System;
using System.IO;

namespace FilewithException
{
    public class age : Exception
    {
        public age(string message) : base(message)
        {
        }
    }
  
    class Program
    {

        static void validate(int age)
        {
           

            if (age < 0)
            {
                throw (new age("Invalid age"));
            }
            
            
        }
        static void Main(string[] args)
        {

            Program f = new Program();

            try
            {
                
                validate(-10);

                try
                {
                   /* int num = 0;
                    int result = 100 / num;*/
                    int[] arr = new int[3] { 5, 10, 15 };
                    Console.WriteLine(arr[4]);


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    FileStream fs = new FileStream("E:\\fileexception.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(e.Message);
                    /*Console.WriteLine("File Save");*/
                    sw.Close();
                    fs.Close();

                }
            }
            catch (age e)
            {

                Console.WriteLine("User defined exception: {0}", e.Message);
                FileStream fs = new FileStream("E:\\fileexception.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(e.Message);
               
                sw.Close();
                fs.Close();

            }
            finally
            {
                Console.WriteLine("File Save Successfully");
            }
        }
    }
}
