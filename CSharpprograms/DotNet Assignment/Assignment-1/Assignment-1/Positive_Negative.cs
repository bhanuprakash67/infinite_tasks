using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Positive_Negative
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());// taking number input
            if (number > 0) // checking whether the number is greater than zero
            {
                Console.WriteLine(number + "is positive number");// printing positive number
            }
            else if (number < 0) // checking whether the number is less than zero 
            {

                Console.WriteLine(number + "is negitive number");// printing negitive number
            }
            else
            {
                Console.WriteLine("Invalid Number");

            }
            Console.ReadLine();
        }
    }
}
