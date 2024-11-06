using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    class Fourth_Question
    {
        public static int CountLetterOccurrences(string input, char letter)
        {
            int count = 0;
            foreach (char ch in input)
            {
                if (char.ToLower(ch) == char.ToLower(letter))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the letter to be counted:");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int occurrences = CountLetterOccurrences(input, letter);
            Console.WriteLine($"The letter '{letter}' appears {occurrences} times in the string.");
        }

    }
}
