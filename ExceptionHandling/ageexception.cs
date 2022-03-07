using System;

namespace ageexception
{
    public class AgevalidateException : Exception
    {
        public AgevalidateException(string message) : base(message)
        {
        }
    }
    public class Age
    {
        int age = 14;
        public void displayAge()
        {
            if (age < 18)
            {
                throw (new AgevalidateException("Age should be greater than 18"));
            }
            else
            {
                Console.WriteLine("Age is: {0}", age);
            }
        }
    }
    class ageexception
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch (AgevalidateException e)
            {
                Console.WriteLine("AgevalidateException: {0}", e.Message);
            }
        }
    }
}
