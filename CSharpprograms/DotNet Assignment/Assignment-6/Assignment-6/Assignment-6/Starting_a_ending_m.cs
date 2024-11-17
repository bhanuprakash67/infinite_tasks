using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Starting_a_ending_m
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            List<string> str = new List<string>();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enetr string {i + 1}");
                str.Add(Console.ReadLine());

            }

            var res = from i in str
                      where i.StartsWith("a") & i.EndsWith("m")
                      select i;
            Console.WriteLine("  ");
            foreach (var j in res)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }


    }
}
