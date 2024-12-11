using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Procedure_using_ADO_classes
{
    public class Program
    {
        public static SqlConnection Sqlcon = null;
        public static SqlCommand cmd = null;
        public static IDataReader reader = null;
        void Insert()
        {
            Sqlcon = new SqlConnection("Data source = ICS-LT-D244D68T; database = SQL_Assesment_3; trusted_connection = true;");
            Sqlcon.Open();
            cmd = new SqlCommand("sp_productdetails", Sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            Console.WriteLine("Enter the product id:");
            int ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product_name:");
            String ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Product price:");
            float Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the discounted Price:");
            float DiscountedPrice = Convert.ToSingle(Console.ReadLine());
            DiscountedPrice = Price - 0.10f;
            cmd.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = ProductId;
            cmd.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = ProductName;
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
            cmd.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;


            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Success:");
            }
            else
            {
                Console.WriteLine("Fail:");
            }
            Sqlcon.Close();

        }
        void select()
        {
            Sqlcon = new SqlConnection("Data source = ICS-LT-D244D6GL; database = ADOAssesment; trusted_connection = true;");
            
            Sqlcon.Open();
            cmd = new SqlCommand("sp_productdetails2", Sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            Console.WriteLine("Enter the product id:");
            int product_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product_name:");
            String Product_name = Console.ReadLine();
            Console.WriteLine("Enter the Product_price:");
            float Product_price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Discounted Price:");
            float Discounted_price = Convert.ToSingle(Console.ReadLine());
            cmd.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = product_id;
            cmd.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = Product_name;
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Product_price;
            cmd.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = Discounted_price;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Product id is:" + reader[0] + "\t" + "product name is:" + reader[1] + "\t" + "product_quantity is:" + reader[2] + "\t" + "product price is:" + reader[3]);
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Insert();
            p.select();
            Console.Read();
        }
    }
}
