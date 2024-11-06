using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class Equal_words
    {
        static void Main()
        {
            Console.WriteLine("Enter First Word");
            string first_word = Console.ReadLine();
            Console.WriteLine("Enter Second Word");
            string second_word = Console.ReadLine();
            if (first_word == second_word)
            {
                Console.WriteLine("First Word and Second Word Are Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.ReadLine();
        }

    }
}
