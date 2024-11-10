using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholarship
    {
        public double Merit(double marks, double fee)
        {
            double scholarship_amount = 0;

            if (marks >= 70 && marks <= 80)
            {
                return scholarship_amount = fee * 0.20;

            }


            else if (marks > 80 && marks <= 90)
            {
                scholarship_amount = fee * 0.30;
                return (scholarship_amount);
            }


            else if (marks > 90)
            {
                scholarship_amount = fee * 0.50;
                return (scholarship_amount);
            }
            return scholarship_amount;
        }
    }
    class scholarship_class
    {
        public static void Main()
        {
            Scholarship scholarship = new Scholarship();
            Console.WriteLine("Enter marks");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fee");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(scholarship.Merit(marks, fee));
            Console.ReadLine();
        }

    }
}