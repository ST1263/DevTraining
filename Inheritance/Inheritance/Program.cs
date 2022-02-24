using System;

namespace Inheritance
{
    public class Emp
    {
        string name;
        
        public void disname()
        {
            name = "Shreyas Tamboli";
            Console.WriteLine("Name:-" + name);
           
        }
    }
    public class Dept : Emp
    {
        string deptname;
        double salary;
        public void details()
        {
            deptname = "Trainee";
            salary = 8000.00;
            Console.WriteLine("Department:-" + deptname);
            Console.WriteLine("Salary" + salary);

        }
    }
    class Program { 
        static void Main(string[] args)
        {
            Dept d = new Dept();
            d.disname();
            d.details();
           



        }
    }
}
