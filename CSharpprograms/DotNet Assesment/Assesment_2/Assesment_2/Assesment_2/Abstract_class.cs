using System;

namespace Abstract_class
{
    public abstract class Student
    {
        public string Student_Name;
        public string Student_Id;
        public double Student_Grade;

        public Student(string name, string studentId, double grade)
        {
            Student_Name = name;
            Student_Id = studentId;
            Student_Grade = grade;
        }

        public abstract string IsPassed();
    }

    public class Undergraduate : Student
    {
        public Undergraduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string IsPassed()
        {
            if (Student_Grade > 70.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    public class Graduate : Student
    {
        public Graduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string IsPassed()
        {
            if (Student_Grade > 80.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type 'Undergraduate' or 'Graduate':");
            string studentType = Console.ReadLine();

            if (studentType.Equals("Undergraduate", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter Undergraduate Student Details:");

                Console.Write("Name: ");
                string undergradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string undergradStudentId = Console.ReadLine();

                Console.Write("Grade: ");
                double undergradGrade = Convert.ToDouble(Console.ReadLine());

                Student undergrad = new Undergraduate(undergradName, undergradStudentId, undergradGrade);
                Console.WriteLine($"{undergrad.Student_Name} {undergrad.IsPassed()} (Undergraduate)");
            }
            else if (studentType.Equals("Graduate", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter Graduate Student Details:");

                Console.Write("Student Name: ");
                string gradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string gradStudentId = Console.ReadLine();

                Console.Write("Student Grade: ");
                double gradGrade = Convert.ToDouble(Console.ReadLine());

                Student grad = new Graduate(gradName, gradStudentId, gradGrade);
                Console.WriteLine($"{grad.Student_Name} {grad.IsPassed()} (Graduate)");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter either 'Undergraduate' or 'Graduate'.");
            }
        }
    }
}