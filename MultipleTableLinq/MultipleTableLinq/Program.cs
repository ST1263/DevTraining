using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleTableLinq
{
    public class Employee
    {
        public int id;
        public string name;
        public int did;
        
    }
    public class Department
    {
        public int did;
        public string deptname;
        public double salary;
    }
   
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>
            {

                new Employee(){ id = 101, name = "Shreyas Tamboli", did = 1 },
                new Employee(){ id = 102, name = "Rutuja Mayura", did = 2},
                new Employee(){ id = 103, name = "Shruti Aadam", did = 3},
                 new Employee(){ id = 104, name = "Piyush Soni", did = 4},
                 new Employee(){ id = 105, name = "Aishyvarya Kote", did = 5},
            };
            List<Department> departments = new List<Department>
            {
                new Department(){did = 1, deptname = "Trainee Engineer", salary = 8000},
                new Department(){did = 2, deptname = "Dev Intern",salary = 10000},
                new Department(){did = 3, deptname = "HR Trainee", salary = 12000},
                new Department(){did = 4, deptname = "QA Trainee", salary = 8000},
                new Department(){did = 5, deptname = "BD Trainee", salary = 10000},
            };
          
            var result = from e in Employees
                            join d in departments on e.did equals d.did
                            select new
                            {
                                EmployeeID = e.id,
                                EmployeeName = e.name,
                                Departmentname = d.deptname,
                               
                            };
            Console.WriteLine("Join using Form query");
            foreach (var value in result)
            {
                Console.WriteLine(value.EmployeeID + "\t\t" +value.EmployeeName + "\t\t" + value.Departmentname);
            }
            var results = Employees.Join( 
                        departments,  
                        employee => employee.did, 
                        department => department.did, 
                        (employee, department) => new 
                        {
                            EmployeeName = employee.name,
                            DepartmentName = department.deptname,
                            Salary = department.salary
                        });
            Console.WriteLine("Join using Extension Method");
            foreach (var value in results)
            {
                Console.WriteLine(value.EmployeeName + "\t\t" + value.DepartmentName + "\t" + value.Salary);
            }
        }
    }
}
