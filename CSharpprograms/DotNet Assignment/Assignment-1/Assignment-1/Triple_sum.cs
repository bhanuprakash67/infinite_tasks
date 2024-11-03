using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Triple_sum
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number:");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int second_number = Convert.ToInt32(Console.ReadLine());
            int sum_of_numbers = first_number + second_number;
            if (first_number == second_number)
            {

                int solution = sum_of_numbers * 3;
                Console.WriteLine(solution);
            }
            else
            {
                Console.WriteLine(sum_of_numbers);
            }
            Console.ReadLine();
        }
    }
 }
