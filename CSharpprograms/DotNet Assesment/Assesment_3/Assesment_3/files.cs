using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assesment_3
{
    class files
    {
        static void Main()
        {
            string filePath = "C:\\DotNet Training\\CSharpprograms\\DotNet Assesment\\Assesment_3\\Bhanu Prakash.txt";
            Console.WriteLine("Enter text to append:");
            string text = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
            Console.WriteLine("Appended text:");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.Read();
        }
    }
}



