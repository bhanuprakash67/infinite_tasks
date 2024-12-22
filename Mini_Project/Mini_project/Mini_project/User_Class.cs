using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mini_project
{
    class User_Class
    {
        public static SqlConnection Sqlcon = null;
        public static SqlCommand Sqlcmd = null;
        public static IDataReader dr = null;
         static int counter = 0;
        public static void User_Menu()
        {
            
            Console.WriteLine("Please View Train Information before Book Tickets");
                Console.WriteLine("1.View Train Information");
                Console.WriteLine("2.Book Tickets");
                Console.WriteLine("3.Cancel Tickets");
            counter++;
            string UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        View_Train_Information();
                        break;
                    case "2":
                        Book_Ticket();
                        break;
                    case "3":
                        Cancel_Ticket();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
           
            
        }
    
        public static void View_Train_Information()
        {
            Sqlcon = new SqlConnection("Data Source = ICS-LT-D244D68T; database =Train_Reservation_Project; trusted_connection = true;");
            Sqlcon.Open();

            Sqlcmd = new SqlCommand("sp_View_Trains_Information", Sqlcon);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = Sqlcmd.ExecuteReader();
            Console.WriteLine("Available Trains");

            while (reader.Read())
            {
                Console.WriteLine($"Train_Number:{reader["Train_number"]},Train_Name:{reader["Train_Name"]}, Source:{reader["Source"]},Destination:{reader["Destination"]},Departure_Time:{reader["Departure_Time"]},Arrival_Time:{reader["Arrival_Time"]},Seats_available:{reader["Seats_available"]},Status:{reader["Status"]}");
            }
            while(counter == 1)
            {
                User_Menu();
                break;
            }
        }
        public static void Book_Ticket()
        {
            Console.WriteLine("Enter Train Number");
            int Train_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train Name");
            string Train_Name = Console.ReadLine();

            Console.WriteLine("Enter Passenger Name");
            string Passenger_Name = Console.ReadLine();

            Console.WriteLine("Enter Passenger Age");
            int Passenger_Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter the Class Type");
            string Class_Type = Console.ReadLine();

            Console.WriteLine("Enter the Number of Seats");
            int Number_of_seats = Convert.ToInt32(Console.ReadLine());

            String status = "Booked";

            Sqlcon = new SqlConnection("Data Source = ICS-LT-D244D68T;database = Train_Reservation_Project;trusted_connection = true");
            Sqlcon.Open();

            Sqlcmd = new SqlCommand("Train_booking_information ", Sqlcon);
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            Sqlcmd.Parameters.AddWithValue("@Train_number", Train_number);
            Sqlcmd.Parameters.AddWithValue("@Train_name", Train_Name);
            Sqlcmd.Parameters.AddWithValue("@Passenger_name ", Passenger_Name);
            Sqlcmd.Parameters.AddWithValue("@Passenger_age", Passenger_Age);
            Sqlcmd.Parameters.AddWithValue("@Gender", gender);
            Sqlcmd.Parameters.AddWithValue("@Class_type", Class_Type);
            Sqlcmd.Parameters.AddWithValue("@Number_of_seats", Number_of_seats);
            Sqlcmd.Parameters.AddWithValue("@status", status);
            int result = Sqlcmd.ExecuteNonQuery();
            if(result > 0)
            {
                Console.WriteLine("Ticket booked successfully:");
            }
            else
            {
                Console.WriteLine("Not booked:");
            }

        }
        public static void Cancel_Ticket()
        {
            Console.WriteLine("Enter the Train number");
            int Train_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Train Name ");
            string Train_Name = Console.ReadLine();

            Console.WriteLine("Enter Passenger Name ");
            string Passenger_Name = Console.ReadLine();

            Console.WriteLine("Enter Passenger Age: ");
            int Passenger_Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Class Type ");
            string Class_Type = Console.ReadLine();

            Console.WriteLine("Enter no.of seats: ");
            int no_of_seats = Convert.ToInt32(Console.ReadLine());

            string Status = "Cancelled";

            Sqlcon = new SqlConnection("Data Source = ICS-LT-D244D68T; database = Train_Reservation_Project;trusted_connection = true");

            Sqlcon.Open();

            Sqlcmd = new SqlCommand("sp_Cancel_Ticket", Sqlcon);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.Parameters.AddWithValue("@Train_number", Train_number);
            Sqlcmd.Parameters.AddWithValue("@Train_Name", Train_Name);
            Sqlcmd.Parameters.AddWithValue("@Passenger_Name", Passenger_Name);
            Sqlcmd.Parameters.AddWithValue("@Passenger_age", Passenger_Age);
            Sqlcmd.Parameters.AddWithValue("@Gender", gender);
            Sqlcmd.Parameters.AddWithValue("@Class_type", Class_Type);
            Sqlcmd.Parameters.AddWithValue("@Number_of_seats", no_of_seats);
            Sqlcmd.Parameters.AddWithValue("@status", Status);
            int result = Sqlcmd.ExecuteNonQuery();
            if(result > 0)
            {
                Console.WriteLine("Ticket Cancelled Successfully");
            }
            else
            {
                Console.WriteLine("Ticket not Cancelled");
            }

        }

    }

}
    

    