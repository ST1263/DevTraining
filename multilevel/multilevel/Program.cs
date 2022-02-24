using System;

namespace multilevel
{
    public class Student
    {
        string name;
        public Student()
        {
            name = "Shreyas Tamboli";
            
        }
        public void Displaystudent()
        {
            Console.WriteLine("Name:-" + name);
        }
    }

    public class Subject :Student
    {
        string sub = "C++";
        public void displasubject()
        {
            Console.WriteLine("Subject=:" + sub);
        }
    }

    public class Marks: Subject
    {
        int marks;
        public Marks( int m)
        {
            marks = m;
            
        }
        public void displaymarks()
        {
            Console.WriteLine("Marks:=" + marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marks m1 = new Marks(50);
            m1.Displaystudent();
            m1.displasubject();
            m1.displaymarks();
        }
    }
}
