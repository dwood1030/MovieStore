using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{ // EDIT TO ENSURE GIT IS SET UP PROPERLY
    internal class Customer
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public double CustomerID { get; private set; }

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

        static List<Customer> customerList = new List<Customer>();
        
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

            // NEED TO GENERATE CUSTOMER ID USING GUID

            string status = "ACTIVE";
            Console.WriteLine($"STATUS: {status}");

            Customer newCustomer = new Customer(firstName, lastName, birthday, email, phoneNumber, address, status);

            Console.WriteLine($"NEW CUSTOMER {newCustomer.Name} HAS BEEN CREATED");

            customerList.Add(newCustomer);

            // HOW TO ADD newCustomer TO A LIST AND HAVE SUBSEQUENT CUSTOMERS NOT OVERRIDE PREVIOUS CUSTOMERS?
        }

        public static void CustomerSearch()
        {
            Console.Write("ENTER CUSTOMER NAME: ");
            Console.ReadLine();

            // HOW TO SEARCH ITEMS ON A LIST?

            // DISPLAY ITEMS CURRENTLY CHECKED OUT TO THIS CUSTOMER

            // HOW TO EDIT THE PROPERTIES OF OBJECTS THAT ARE ON THAT LIST?
            Console.WriteLine("WOULD YOU LIKE TO EDIT THIS CUSTOMER? INPUT 'Y' OR 'N'");
            string editCustomer = Console.ReadLine();
            if (editCustomer == "Y" | editCustomer == "y")
            {
                Console.WriteLine("WHAT WOULD YOU LIKE TO EDIT?");
                string input = Console.ReadLine();

                switch(input) // NEED TO ADD LOOP SO SWITCH KEEPS GOING UNTIL A VALID INPUT IS ENTERED
                {
                    case "FIRST NAME":
                        Console.WriteLine("PLEASE ENTER NEW FIRST NAME");
                        Console.ReadLine();
                        break;

                    case "LAST NAME":
                        Console.WriteLine("PLEASE ENTER NEW LAST NAME");
                        Console.ReadLine();
                        break;

                    case "PHONE NUMBER":
                        Console.WriteLine("PLEASE ENTER NEW PHONE NUMBER");
                        Console.ReadLine();
                        break;

                    case "EMAIL":
                        Console.WriteLine("PLEASE ENTER NEW EMAIL");
                        Console.ReadLine();
                        break;

                    case "ADDRESS":
                        Console.WriteLine("PLEASE ENTER NEW ADDRESS");
                        Console.ReadLine();
                        break;

                    case "STATUS":
                        Console.WriteLine("PLEASE ENTER NEW CUSTOMER STATUS");
                        Console.WriteLine("CUSTOMER STATUS CAN ONLY BE ACTIVE OR INACTIVE");
                        string customerStatus = Console.ReadLine();
                        // ERROR HANDLING NEEDS TO BE ADDED HERE
                        break;

                    default:
                        Console.WriteLine("INPUT INVALID. ENTER ONE OF THE FOLLOWING:");
                        Console.WriteLine("FIRST NAME, LAST NAME, PHONE NUMBER, EMAIL, ADDRESS, STATUS");
                        break;
                }
            }
            else
            {
                Console.WriteLine("WOULD YOU LIKE TO SEARCH ANOTHER CUSTOMER?");

                // NEED TO ADD LOOP TO ALLOW USER TO SEARCH ANOTHER CUSTOMER
            }

        }
    }
}
