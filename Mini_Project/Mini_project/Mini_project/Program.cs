using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Mini_project
{
    class Program
    {
        public static string user_name = "Bhanu Prakash";
        public static string password = "Bobby@123";

        public static void login_credentials()
        {
            
            Console.WriteLine("Enter the User Name");
            string User_Name = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();

            if (user_name == "Bhanu Prakash" && password == "Bobby@123")
            {
                Console.WriteLine("Login Successfully");
                Admin_Class.Admin_block();
            }
            else
            {
                Console.WriteLine("Invail User name or password");
            }
        }
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose One Option");
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.User");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Enter your choice(1/2/3):");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        login_credentials();
                        Admin_Class.Admin_block();
                        break;
                    case 2:
                        User_Class.User_Menu();
                        break;
                    case 3:
                        Exit_Class.Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid option.Please try again");
                        break;
                }
                if(option == 3)
                {
                    Console.WriteLine("Thank you:");
                    break;
                }
            }
            Console.Read();
        }
    }
}
        
        
        
        
        
        
        
