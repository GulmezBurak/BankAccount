using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {

        static List<Costumer> clist = new List<Costumer>();
        static void Main(string[] args)
        {
            LoginAccount();

        }

        private static void LoginAccount()
        {
            Console.WriteLine("Welcome ! Please enter your username.");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your password.");
            int password = Convert.ToInt32(Console.ReadLine());

            Costumer costumer = new Costumer();
            costumer.Name = "Burak";
            costumer.Surname = "Gulmez";
            costumer.UserName = "burakgulmez";
            costumer.Id = 1;
            costumer.Password = 2121;
            if (userName == costumer.UserName && password == costumer.Password)
            {
                Console.WriteLine("Hello, " + costumer.Name + " " + costumer.Surname);
                MenuBar();
            }
            else
            {
                Console.WriteLine("Username or password is incorrect, please try again.");
                Console.ReadLine();
                LoginAccount();
            }


        }

        private static void MenuBar()
        {
            Console.WriteLine("Please choose which action do you want.");
            Console.WriteLine("1-View the balance in the account");
            Console.WriteLine("2-Send money to the account.");

            string choose = Console.ReadLine();
            if (choose == "1")
            {
                ViewBalance();
                Console.ReadLine();
                MenuBar();
            }
            else if (choose == "2")
            {
                MoneySend();
                Console.ReadLine();
                MenuBar();
            }
            else
            {
                Console.WriteLine("You entered wrong value.Please enter 1 or 2 values.");
                Console.ReadLine();
                MenuBar();
            }
        }

        private static void MoneySend()
        {
            int balance = 0;
            Console.WriteLine("How much money do you want to send?");
           int amount =  Convert.ToInt32(Console.ReadLine());
            if (balance == 0 || balance < amount)
            {
                Console.WriteLine("Insufficient balance. Transaction failed");
            }
            else
            {
                Console.WriteLine("Transaction succesfully done.");
                int newBalance = balance - amount;
                Console.WriteLine("Your balance is " + newBalance + " TL");

            }

        }

        private static void ViewBalance()
        {
            int balance = 1000;
            Console.WriteLine("Your balance is : " + balance + " TL");
        }
    }
}