using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            { 
                Console.WriteLine($"Enter element {i + 1}");
                l.Add(int.Parse(Console.ReadLine()));
            }
            var res = from i in l
                      where i * i > 20
                      select i;
            foreach (var j in res)
            {
                Console.WriteLine($"{j} -> {j * j}");
            }
            Console.ReadLine();
        }
    }
}

