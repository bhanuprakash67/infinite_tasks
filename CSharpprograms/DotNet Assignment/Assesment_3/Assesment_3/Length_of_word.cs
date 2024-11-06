using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class Length_of_word
    {
        static void Main()
        {
            Console.WriteLine("Enter a word");
            string name = Console.ReadLine();
            int len_name = name.Length;
            Console.WriteLine(len_name);
            Console.ReadLine();
        }
    }
}
