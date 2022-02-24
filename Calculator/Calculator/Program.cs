using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            /*string status;*/
            int answer;

            do
            {
                Console.Write("Enter First Number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operand:-  ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }
                Console.WriteLine(answer);
             Console.WriteLine("Do you want to continue (Y/N)? ");
            }while (Console.ReadLine() != "Y");
        }
    }
}
