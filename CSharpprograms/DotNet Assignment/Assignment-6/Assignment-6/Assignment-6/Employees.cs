using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Employees
    {
        public int EmployeeId;
        public string EmployeeName;
        public string EmployeeCity;
        public float EmployeeSalary;
    }
    class Question3
    {
        static void Main()
        {
            List<Employees> emp = new List<Employees>();
            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Employee {i + 1} details");
                int EmpId = int.Parse(Console.ReadLine());

                string EmpName = Console.ReadLine();
                string EmpCity = Console.ReadLine();
                float EmpSalary = Convert.ToSingle(Console.ReadLine());
                emp.Add(new Employees
                {
                    EmployeeId = EmpId,
                    EmployeeName = EmpName,
                    EmployeeCity = EmpCity,
                    EmployeeSalary = EmpSalary
                }
                  );
            }
            Console.WriteLine("Display all employees");
            foreach (var e in emp)
            {
                Console.WriteLine($"Emp Id  : {e.EmployeeId}, Emp Name  :   {e.EmployeeName}, Emp City  : {e.EmployeeCity}, Emp Salary  : {e.EmployeeSalary}");
            }
            Console.WriteLine("greater than 4500");

            var empb = emp.Where(e => e.EmployeeSalary > 4500).ToList();
            foreach (var e in empb)
            {
                Console.WriteLine($"Emp Id  :   {e.EmployeeId}, Emp Name  :   {e.EmployeeName}, Emp City  :   {e.EmployeeCity}, Emp Salary  :   {e.EmployeeSalary}");
            }
            Console.WriteLine("belong to banglore region");

            var empc = emp.Where(e => e.EmployeeCity == "banglore").ToList();
            foreach (var e in empc)
            {
                Console.WriteLine($"Emp Id  :  {e.EmployeeId}, Emp Name  :   {e.EmployeeName}, Emp City  :   {e.EmployeeCity}, Emp Salary  :   {e.EmployeeSalary}");
            }
            Console.WriteLine("in Ascending order");

            var empd = emp.OrderBy(e => e.EmployeeName).ToList();
            foreach (var e in empd)
            {
                Console.WriteLine($"Emp Id  :   {e.EmployeeId}, Emp Name  :   {e.EmployeeName}, Emp City  :   {e.EmployeeCity}, Emp Salary  :   {e.EmployeeSalary}");
            }
            Console.ReadLine();
        }
    }
}

