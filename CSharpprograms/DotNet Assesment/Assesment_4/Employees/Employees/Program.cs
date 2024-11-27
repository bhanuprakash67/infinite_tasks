using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{ 
    public class Employee
    {
        public int Employee_ID
        {
            get;
            set;
        }
        public string First_Name
        {
            get;
            set;
        }
        public string Last_Name
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public DateTime DOB
        {
            get;
            set;
        }
        public DateTime DOJ
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Creating the list of employees
            List<Employee> empList = new List<Employee>
{
new Employee { Employee_ID = 1001, First_Name = "Malcolm", Last_Name = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
new Employee { Employee_ID = 1002, First_Name = "Asdin", Last_Name = "Dhalla", Title = "AsstManager", DOB = new DateTime(1994, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
new Employee { Employee_ID = 1003, First_Name = "Madhavi", Last_Name = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
new Employee { Employee_ID = 1004, First_Name = "Saba", Last_Name = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
new Employee { Employee_ID = 1005, First_Name = "Nazia", Last_Name = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
new Employee { Employee_ID = 1006, First_Name = "Amit", Last_Name = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
new Employee { Employee_ID = 1007, First_Name = "Vijay", Last_Name = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
new Employee { Employee_ID = 1008, First_Name = "Rahul", Last_Name = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
new Employee { Employee_ID = 1009, First_Name = "Suresh", Last_Name = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
new Employee { Employee_ID = 1010, First_Name = "Sumit", Last_Name = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
};



            //Display details of all employee
            Console.WriteLine("-----query-1-------");
            var allEmployees = empList;
            Console.WriteLine("Details of all employees ");
            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"{emp.Employee_ID} {emp.First_Name} {emp.Last_Name} {emp.Title} {emp.DOB.ToShortDateString()} {emp.DOJ.ToShortDateString()} {emp.City}");
            }

            //Display details of all employees whose location is not Mumbai
            Console.WriteLine("--------query-2-------");
            var nonMumbaiEmployees = empList.Where(e => e.City != "Mumbai");
            Console.WriteLine("\nEmployees Not in Mumbai:");
            foreach (var emp in nonMumbaiEmployees)
            {
                Console.WriteLine($"{emp.Employee_ID} {emp.First_Name} {emp.Last_Name} {emp.City}");
            }

            //Display details of employees with the title 'AsstManager'
            Console.WriteLine("---------query-3--------");
            var asstManagers = empList.Where(e => e.Title == "AsstManager");
            Console.WriteLine("\nAsstManagers:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"{emp.Employee_ID} {emp.First_Name} {emp.Last_Name} {emp.Title}");
            }

            //Display details of employees whose last name starts with 'S'
            Console.WriteLine("--------query-4---------");
            var employeesWithS = empList.Where(e => e.Last_Name.StartsWith("S"));
            Console.WriteLine("\nEmployees Whose Last Name Starts with 'S':");
            foreach (var emp in employeesWithS)
            {
                Console.WriteLine($"{emp.Employee_ID} {emp.First_Name} {emp.Last_Name}");
            }
            Console.ReadLine();
        }
    }
}


