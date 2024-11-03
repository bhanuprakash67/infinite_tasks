using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class ten_marks
    {
        static void Main()
        {
            Console.WriteLine("Enter 10 Values");
            int[] array_1 = new int[10];
            for (int i = 0; i < array_1.Length; i++)
            {
                array_1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Addition");
            int total = 0;
            for (int i = 0; i < array_1.Length; i++)
            {
                total = total + array_1[i];
            }
            Console.WriteLine(total);
            Console.WriteLine("Average");
            int average = 0;
            for (int i = 0; i < array_1.Length; i++)
            {
                average = total / array_1[i];
            }
            Console.WriteLine(average);
            Console.WriteLine("Minimum Marks");

            int minimum_marks = array_1.Min();

            Console.WriteLine(minimum_marks);
            Console.WriteLine("Maximum Marks");

            Console.WriteLine(" ");
            int maximum_marks = array_1.Max();
            Console.WriteLine(maximum_marks);

            Console.WriteLine("Ascending Order");
            for (int i = 0; i < array_1.Length; i++)
            {
                for (int j = i + 1; j < array_1.Length; j++)
                {
                    if (array_1[i] > array_1[j])
                    {
                        int temp = array_1[i];
                        array_1[i] = array_1[j];
                        array_1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array_1.Length; i++)
            {
                Console.WriteLine("ascending " + array_1[i]);
            }

            Console.WriteLine("Descending order");
            for (int i = 0; i < array_1.Length; i++)
            {
                for (int j = i + 1; j < array_1.Length; j++)
                {
                    if (array_1[i] < array_1[j])
                    {
                        int temp = array_1[i];
                        array_1[i] = array_1[j];
                        array_1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array_1.Length; i++)
            {
                Console.WriteLine("descending " + array_1[i]);
            }


            Console.ReadLine();
        }
    }
}

