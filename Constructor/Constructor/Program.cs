using System;

namespace Constructor
{
    public class Program
    {
        int fno;
        int sno;
        int ans;

            
        public Program()
            {
            fno = 0;
            sno = 0;

            Console.WriteLine("Default Constructor");
            }
        public Program(int i, int j)
        {
            fno = i;
            sno = j;
        }
        public void AddDisplay()
        {
            ans = fno + sno;
            Console.WriteLine("Addition is:- " + ans);
        }
        static void Main(string[] args)
        {
            Program p = new Program(10,20);
            p.AddDisplay();

        }
    }
}
