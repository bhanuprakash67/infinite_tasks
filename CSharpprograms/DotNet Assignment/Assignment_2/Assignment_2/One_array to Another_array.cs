using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class One_array_to_Another_array
    {
        static void Main()
        {
            int[] array_1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array_2 = array_1;
            for (int i = 0; i < array_2.Length; i++)
            {
                Console.Write(array_2[i] + " ");

            }

            Console.ReadLine();
        }
    }
}
