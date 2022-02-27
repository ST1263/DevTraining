using System;

namespace Overrideing
{
    class Studnet
    {
        
       public virtual void show()
        {
            Console.WriteLine("Shreyas");

        }
    }
    class Stud : Studnet
    {
       
        public override void show()
        {
            Console.WriteLine("Tamboli");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stud s = new Stud();
            s.show();
           /* Studnet s1 = new Studnet();
            s1.show();*/

        }
    }
}
