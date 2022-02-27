using System;

namespace abstractclass
{
    public abstract class Math
    {
        public abstract void cal(int x);
    
      
    }
    class square : Math
    {
        int a;
        int sq;
        public override void cal(int x)
        {
            a = x;
            sq = a * a;
            Console.WriteLine("Area of Square is " + sq);
        }
    }
    public class cube : Math
    {

        int c;
        int cu;
        public override void cal(int x)
        {
            c = x;
            cu = x * x *x;
            Console.WriteLine("Cube is :" + cu);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           square s = new square();
            cube c1 = new cube();
            s.cal(10);
            c1.cal(5);
                    
        }
    }
}
