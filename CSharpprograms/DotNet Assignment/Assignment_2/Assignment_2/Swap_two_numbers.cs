using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Swap_two_numbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Before Swapping");

            Console.WriteLine(a);
            Console.WriteLine(b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Numbers after swapping");
            Console.WriteLine(a);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}

