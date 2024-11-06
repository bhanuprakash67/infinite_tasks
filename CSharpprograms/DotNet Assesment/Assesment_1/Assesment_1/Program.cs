using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    class HelloWorld
    {
        public static string Remove(string a, int b)
        {
            string c = "";
            for (int i = 0; i < a.Length; i++)
            {
                char ch = a[i];
                if (i != b)
                {
                    c += ch;
                }
            }
            return c;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the index of the character to remove:");
            int b = Convert.ToInt32(Console.ReadLine());
            string result = Remove(a, b);
            Console.WriteLine(result);
        }
    }
}