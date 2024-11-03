using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Multiplication_table
    {
        static void Main()
        {

            Console.WriteLine("Enter a Numnber");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int solution = number * i;
                Console.WriteLine(number + " " + "*" + " " + i + " " + "=" + " " + solution);
            }
            Console.ReadLine();
        }
    }
}
