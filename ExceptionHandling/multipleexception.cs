
using System;


namespace multipleexception
{
    class multipleexception
    {
        static void Main(string[] args)
        {
            int num1, num2, ans;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                ans = num1 / num2;
                Console.WriteLine("Answer = " + ans);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Run Successfully");
            }
           
        }

        

    }
}

