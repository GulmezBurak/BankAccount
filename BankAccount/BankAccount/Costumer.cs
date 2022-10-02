using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Password { get; set; }

        public void CapitalLetter(string Name, string Surname)
        {
            Name = Name.ToUpper();
            Surname = Surname.ToUpper();
        }
    }
}
        