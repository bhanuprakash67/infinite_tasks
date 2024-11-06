using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Display_it_four_time
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", a);
                Console.WriteLine("{0}{0}{0}{0}", a);
            }
            for (int j = 1; j < 2; j++)
            {
                Console.WriteLine("{0} {0} {0} {0}", a);
                Console.WriteLine("{0}{0}{0}{0}", a);
                Console.ReadLine();
            }
        }
    }
}
