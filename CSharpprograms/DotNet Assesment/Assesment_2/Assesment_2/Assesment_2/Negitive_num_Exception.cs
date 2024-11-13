using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    class Negitive_num_Exception
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                CheckNegativeNumber(number);
                Console.WriteLine("The number is valid.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.Read();
        }

        static void CheckNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("The number cannot be negative.");
            }

        }
    }
}

