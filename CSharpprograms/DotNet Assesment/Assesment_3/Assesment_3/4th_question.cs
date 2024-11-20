using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class _4th_question
    {
        public delegate int CalculatorDelegate(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");

            Console.Write("Enter your choice (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            CalculatorDelegate calcDelegate = null;
            switch (choice)
            {
                case 1:
                    calcDelegate = Add;
                    break;
                case 2:
                    calcDelegate = Subtract;
                    break;
                case 3:
                    calcDelegate = Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            int result = calcDelegate(num1, num2);
            Console.WriteLine($"The result is: {result}");
            Console.Read();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
