using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{
    internal class Customers
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public double CustomerID { get; set; }

        public string Status { get; set; }

        
        public static void NewCustomer()
        {
            Console.WriteLine();
            Console.Write("FIRST NAME: ");
            string firstName = Console.ReadLine();
            Console.Write("LAST NAME: ");
            string lastName = Console.ReadLine();
            Console.Write("BIRTHDAY: ");
            string birthday = Console.ReadLine();
            Console.Write("EMAIL: ");
            string email = Console.ReadLine();
            Console.Write("ADDRESS: ");
            string address = Console.ReadLine();

        }
    }
}
