using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mini_project
{
    class Admin_Class
    {
        public static SqlConnection Sqlconn = null;
        public static SqlCommand Sqlcmd = null;
        public static IDataReader dr = null;



        public static void Admin_block()
        {

            Console.WriteLine("Select one option 1.Add Trains or 2.Modify Trains or 3.Delete Trains");
            Console.WriteLine("1.Add Trains");
            Console.WriteLine("2.Modify Trains");
            Console.WriteLine("3.Delete Trains");
            Console.WriteLine("4.Exit");

            Console.WriteLine("Enter your choice(1/2/3/4):");
            int AdminChoice = Convert.ToInt32(Console.ReadLine());

            switch (AdminChoice)
            {
                case 1:
                    Add_Trains();
                    break;
                case 2:
                    Modify_Trains();
                    break;
                case 3:
                    Delete_Trains();
                    break;
                case 4:
                    Console.WriteLine("Thank you:");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
            public static void Add_Trains()
            {

                Console.WriteLine("Enter Train Number");
                int Train_number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Train Name");
                string Train_Name = Console.ReadLine();

                Console.WriteLine("Enter the Source");
                string Source = Console.ReadLine();

                Console.WriteLine("Destination");
                string Destination = Console.ReadLine();

                Console.WriteLine("Enter Departure Time");
                DateTime Departure_time = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter Arrival Time");
                DateTime Arrival_time = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter The Seats Available");
                int Seats_Available = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Status");
                String Status = Console.ReadLine();


                Sqlconn = new SqlConnection("Data Source = ICS-LT-D244D68T; database =Train_Reservation_Project; trusted_connection = true");
                Sqlconn.Open();

                Sqlcmd = new SqlCommand("sp_Add_Trains", Sqlconn);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@Train_number", Train_number);
                Sqlcmd.Parameters.AddWithValue("@Train_Name", Train_Name);
                Sqlcmd.Parameters.AddWithValue("@Source", Source);
                Sqlcmd.Parameters.AddWithValue("@Destination", Destination);
                Sqlcmd.Parameters.AddWithValue("@Departure_time", Departure_time);
                Sqlcmd.Parameters.AddWithValue("@Arrival_time", Arrival_time);
                Sqlcmd.Parameters.AddWithValue("@Seats_available", Seats_Available);
                Sqlcmd.Parameters.AddWithValue("@Status", Status);
                Sqlcmd.ExecuteNonQuery();
                Console.WriteLine("Train added successfully");

            }

            public static void Modify_Trains()
            {
                Console.WriteLine("Enter Train Number to Modify:");
                int Train_number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Train Name to Modify");
                string Train_Name = Console.ReadLine();

                Console.WriteLine("Enter the Source Name to Modify");
                string Source = Console.ReadLine();

                Console.WriteLine("Enter the Destination Name to Modify");
                string Destination = Console.ReadLine();

                Console.WriteLine("Enter the Departure Time to Modify");
                DateTime Departure_time = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the Arrival Time to Modify");
                DateTime Arrival_time = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the Status to Modify");
                string Status = Console.ReadLine();


                Sqlconn = new SqlConnection("Data Source = ICS-LT-D244D68T; database = Train_Reservation_Project; trusted_connection = true");
                Sqlconn.Open();
                Sqlcmd = new SqlCommand("sp_Update_trains", Sqlconn);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@Train_number", Train_number);
                Sqlcmd.Parameters.AddWithValue("@Train_Name", Train_Name);
                Sqlcmd.Parameters.AddWithValue("@Source", Source);
                Sqlcmd.Parameters.AddWithValue("@Destination", Destination);
                Sqlcmd.Parameters.AddWithValue("@Departure_time", Departure_time);
                Sqlcmd.Parameters.AddWithValue("@Arrival_time", Arrival_time);
                Sqlcmd.Parameters.AddWithValue("@Status", Status);
                Sqlcmd.ExecuteNonQuery();
                Console.WriteLine("Train details updated");


            }
            public static void Delete_Trains()
            {

                Console.WriteLine("Enter Train Number to Delete");
                int Train_number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Train Name to Delete");
                string Train_Name = Console.ReadLine();

                Console.WriteLine("Enter the Source to Delete");
                string Source = Console.ReadLine();

                Console.WriteLine("Enter the Destination to Delete");
                string Destination = Console.ReadLine();

                Sqlconn = new SqlConnection("Data Source = ICS-LT-D244D68T; database = Train_Reservation_Project; trusted_connection = true");
                Sqlconn.Open();
                Sqlcmd = new SqlCommand("sp_delete_trains", Sqlconn);
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(new SqlParameter("@Train_number", SqlDbType.Int)).Value = Train_number;
                Sqlcmd.Parameters.Add(new SqlParameter("@Train_Name", SqlDbType.VarChar)).Value = Train_Name;
                Sqlcmd.Parameters.Add(new SqlParameter("@Source", SqlDbType.VarChar)).Value = Source;
                Sqlcmd.Parameters.Add(new SqlParameter("@Destination", SqlDbType.VarChar)).Value = Destination;

                int result = Sqlcmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Train Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Train not Deleted");
                }


            }
        }

    }

