using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Menu:Costumer
    {
        public static void MenuBar()
        {
            Console.WriteLine("1-View the balance in the account");
            Console.WriteLine("2-Send money to the account.");
            
            string Choose = Console.ReadLine();
            if (Choose == "1")
            {
                ViewBalance();
                Console.ReadLine();
                MenuBar();
            }
            else if (Choose == "2")
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
        public static void ViewBalance()
        {

        }
        public static void MoneySend()
        {
            
        }       
    }
}
