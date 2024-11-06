using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            int findingLenght = word.Length;
            Console.WriteLine("The lenght of the word is: " + findingLenght);
            Console.ReadLine();
        }
    }
}
