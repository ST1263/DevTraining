using System;

namespace Interface
{
    interface IShape
    {
        void calculateArea();

    }
    class Rectangle : IShape
    {
        public void calculateArea()
        {

            int l = 20;
            int b = 40;
            int areaofrect = l * b;
            Console.WriteLine("Area of Rectangle: " + areaofrect);
        }
    }
    class Square : IShape
    {
        public void calculateArea()
        {

            int side = 10;
            int areaofsq = side * side;
            Console.WriteLine("Area of Square: " + areaofsq);
        }
    }
    class Program
{
    static void Main(string[] args)
    {
            Rectangle rect = new Rectangle();
            rect.calculateArea();

            Square sq = new Square();
            sq.calculateArea();
    }
}
}
