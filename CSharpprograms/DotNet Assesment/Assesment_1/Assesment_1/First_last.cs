﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assesment
{
    class HelloWorld
    {
        public static string ExchangeFirstAndLast(string input)
        {


            if (input.Length <= 1)
            {
                return input;
            }

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string middle = input.Substring(1, input.Length - 2);

            return lastChar + middle + firstChar;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            string result = ExchangeFirstAndLast(input);
            Console.WriteLine(result);
        }
    }
}
