using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class All_Operations
    {
        static void Main()
        {

            Console.WriteLine("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            String Operator = Console.ReadLine();
            Console.WriteLine("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (Operator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);// Addition
            }
            else if (Operator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);//Subraction
            }
            else if (Operator == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);//Multiplication
            }
            else if (Operator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);//Division
            }
            Console.ReadLine();
        }
    }
 }