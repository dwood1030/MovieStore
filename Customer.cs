using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{
    internal class Customer
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public double CustomerID { get; set; }

        public string Status { get; set; }

        public Customer(string firstName, string lastName, string birthday, string email, string phoneNumber, string address, string status)
        {
            Name = firstName + " " + lastName;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Status = status;
        }

        
        public static void NewCustomer()
        {
            Console.WriteLine();
            Console.Write("FIRST NAME: ");
            string firstName = Console.ReadLine();
            Console.Write("LAST NAME: ");
            string lastName = Console.ReadLine();
            Console.Write("BIRTHDAY: ");
            string birthday = Console.ReadLine();
            Console.Write("PHONE NUMBER: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("EMAIL: ");
            string email = Console.ReadLine();
            Console.Write("ADDRESS: ");
            string address = Console.ReadLine();
            // need create a customer ID using GUID
            string status = "ACTIVE";
            Console.WriteLine($"STATUS: {status}");

            Customer customer1 = new Customer(firstName, lastName, birthday, email, phoneNumber, address, status);

            Console.WriteLine($"NEW CUSTOMER {firstName} {lastName} HAS BEEN CREATED");

            Console.WriteLine("Name = {0}", customer1.Name);
        }

        public static void CustomerSearch()
        {
            
        }
    }
}
