using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    class Reverse_word
    {
        public void Main()
        {
            Console.WriteLine("Enter a Word");
            string name = Console.ReadLine();
            string reversed = "";
            for (int i = name.Length -1; i >= 0; i--)
            {
                reversed = reversed + name[i];
            }
            Console.ReadLine();
        }
        
    }
}
