using System;

namespace overloding
{
    class Student
    {
        int rollno;
        string sname;
        
        void Display(int id)
        {
            rollno = id;
            Console.WriteLine("RollNo is " + id);
        }
        void Display( string name)
        {
            
            sname = name;
            Console.WriteLine("Student Name is " + name);

        }
        
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display(101);
            s.Display("Shreyas");
           

           
        }
    }
}
