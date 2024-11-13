using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    public class Product
    {
        public int Product_Id;
        public string Product_Name;
        public double Product_Price;

        public Product(int productId, string productName, double price)
        {
            Product_Id = productId;
            Product_Name = productName;
            Product_Price = price;
        }
    }

    class Products
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(productId, productName, price);
            }

            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - i - 1; j++)
                {
                    if (products[j].Product_Price > products[j + 1].Product_Price)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Products based on Price:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product ID: {products[i].Product_Id}, Name: {products[i].Product_Name}, Price: {products[i].Product_Price:C}");
            }
        }
    }
}
