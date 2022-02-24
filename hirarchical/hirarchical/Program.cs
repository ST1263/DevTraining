using System;

namespace hirarchical
{
    public class Emp
    {
        string name;
        public void Disname()
        {
            name = "Shreyas";
            Console.WriteLine("Name:=" +name);
        }
    }

    public class Dept : Emp
    {
        public void disDept()
        {
            Console.WriteLine("HR");
        }
    }

    public class Salary : Emp
    {
        int sal= 15000;
        public void saldis()
        {
            Console.WriteLine("Salary=" + sal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary();
            Dept d = new Dept();
            s.Disname();
            s.saldis();

            d.disDept();
            



        }
    }
}
