using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Books
{
        class Count_No_Of_Lines_In_The_File
        {
            public static void Main(string[] args)
            {
                string path = @"C:\DotNet Training\bittu.txt";
                if (File.Exists(path))
                {
                    int count = File.ReadAllLines(path).Length;
                    Console.WriteLine("Number of Lines in the file is: {0}", count);
                }
                else
                {
                    Console.WriteLine("File not Exist");
                }
                Console.Read();
            }
        }
}

