using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class Reversed_word
    {
        static void Main()
        {
            Console.WriteLine("Enter a Word");
            string word = Console.ReadLine();
            string reversed = "";
            for(int i = word.Length-1; i >= 0; i--)
            {
                reversed = reversed + word[i];
            }
            Console.WriteLine(reversed);
            Console.ReadLine();
        }
    }
}
