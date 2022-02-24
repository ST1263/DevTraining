using System;

namespace Oops
{
    public class Emp
    {
        int empid;
        string empname;
        double salary;
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.empid = 1;
            e.empname ="Shreyas Tamboli";
            e.salary = 8000.00;
            Console.WriteLine("Employee ID:-" + e.empid);
            Console.WriteLine("Employee Name:-" + e.empname);
            Console.WriteLine("Employee Salary:-" + e.salary);
        }
    }
}
