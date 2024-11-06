using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    class find_largest_number
    {
        static void Main(string[] arrgs)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int largest = find_largest_number(num1, num2, num3);
            Console.WriteLine(largest);
        }
        static int find_largest_number(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)

                return b;
        }
    }
}
