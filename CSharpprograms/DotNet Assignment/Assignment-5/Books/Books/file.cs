using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class file
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Enter string {i + 1}");
                str[i] = Console.ReadLine();
            }


            string write_path = "Question2.txt";
            FileStream fileStream = new FileStream(write_path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            foreach (string s in str)
            {
                streamWriter.WriteLine(s);
            }
            Console.WriteLine("The Words are stored in the File");
            streamWriter.Flush();
            streamWriter.Close();
            streamWriter.Close();
            Console.ReadLine();
        }
    }
}

