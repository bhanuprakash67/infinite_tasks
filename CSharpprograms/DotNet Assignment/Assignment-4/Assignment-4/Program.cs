﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class BankAccount
    {
        public int amount, balance;
        public String transaction_type;

        void Credit()
        {
            try
            {
                Console.WriteLine("Enter the money to be credited:");
                amount = Convert.ToInt32(Console.ReadLine());
                balance = balance + amount;
                Console.WriteLine("The available balance is:" + balance);
                Console.WriteLine("Transaction is completed:");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter numbers:");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured:" + e.Message);
            }
        }
        void Debit()
        {
            try
            {
                Console.WriteLine("Enter the money to be debit:");
                amount = Convert.ToInt32(Console.ReadLine());
                balance = balance - amount;
                if (balance > 0)
                {

                    Console.WriteLine("Successfully Debited the amount is:" + amount);
                    Console.WriteLine("The available balance is:" + balance);
                    Console.WriteLine("The transaction is completed:");
                }
            }
            catch (FormatException f)
            {
                Console.WriteLine("Please Enter numbers:");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured:" + e.Message);
            }


        }



        public void UpdateBalance()
        {

            String type = transaction_type.ToLower();


            if (type == "debit")
            {
                Debit();
            }
            else if (type == "credit")
            {
                Credit();
            }
            else
            {
                Console.WriteLine("Enter Debit or Credit:");
            }

        }
    }
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(String Transaction_type) : base(Transaction_type)
        {

        }
        public static void Main(String[] args)
        {
            BankAccount b = new BankAccount();

            Console.WriteLine("Enter the transaction type :: Debit or Credit");
            b.transaction_type = Console.ReadLine();
            b.UpdateBalance();
            try
            {
                if (b.balance < 0)
                {
                    throw new InsufficientBalanceException("An Exception as occured:");
                }
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine("Inssufficient Balance:");
            }

            Console.Read();
        }
    }
}