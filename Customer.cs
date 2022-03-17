using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

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

        public Guid CustomerID { get; private set; }

        public string Status { get; set; }

        public Customer(string firstName, string lastName, string birthday, string email, string phoneNumber, string address, Guid customerID, string status)
        {
            Name = firstName + " " + lastName;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            CustomerID = customerID;
            Status = status;
        }

        static List<Customer> customerList = new List<Customer>(); // how to make list not overwrite what is already in the JSON file
        
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

            Guid customerID = Guid.NewGuid();

            string status = "ACTIVE";
            Console.WriteLine($"STATUS: {status}");

            Customer newCustomer = new Customer(firstName, lastName, birthday, email, phoneNumber, address, customerID, status);

            Console.WriteLine($"NEW CUSTOMER {newCustomer.Name} HAS BEEN CREATED");

            customerList.Add(newCustomer);

            string json = JsonSerializer.Serialize(customerList);
            File.WriteAllText(@"customerList.json", json);
        }

        public static bool CustomerSearch()
        {

            // HOW TO SEARCH JSON FILE

            // first deserialize JSON file

            string jsonString = File.ReadAllText(@"customerList.json");
            var customer = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;
            
            // enter customer name and select it using a LINQ query

            Console.Write("ENTER CUSTOMER NAME: ");
            string search = Console.ReadLine();

            //IEnumerable<Customer> can also be written in place of var queryAllCustomers
            var queryAllCustomers = from cust in customerList
                                    where cust.Name == search
                                    select cust;

            // then display properties of object

            foreach(Customer cust in queryAllCustomers) // WHY IS THIS NOT DISPLAYING INFO??
            {
                Console.WriteLine("{0}, {1} , {2}, {3}, {4}, {5}, {6}", cust.Name, cust.Birthday, cust.Email, cust.PhoneNumber, cust.Address, cust.CustomerID, cust.Status);
            }
                
            // HOW TO EDIT THE PROPERTIES OF OBJECTS IN JSON FILE?
            Console.WriteLine("WOULD YOU LIKE TO EDIT THIS CUSTOMER? INPUT 'Y' OR 'N'");
            string edit = Console.ReadLine();
            Console.WriteLine();

            switch(edit)
            {
                case "Y":
                    EditCustomer();
                    break;

                case "N":
                    Console.WriteLine("RETURNING TO MAIN MENU");
                    return false;

                default:
                    Console.WriteLine("INPUT INVALID.");
                    break;
            }
            //if (editCustomer == "Y" | editCustomer == "y")
            //{ 
            //    EditCustomer(); 
            //}
            //else if (editCustomer == "N" | editCustomer == "n")
            //{
            //    Console.WriteLine("RETURNING TO MAIN MENU");
            //    return false;
            //}
            //else
            //{
            //    Console.WriteLine("WOULD YOU LIKE TO SEARCH ANOTHER CUSTOMER? INPUT 'Y' OR 'N'");
            //    string searchAgain = Console.ReadLine();
                
            //    if (searchAgain == "Y" | searchAgain == "y")
            //    {

            //    }

            //    // NEED TO ADD LOOP TO ALLOW USER TO SEARCH ANOTHER CUSTOMER or return to main menu
            //}

            return true;
        }

        public static bool EditCustomer()
        {
            Console.WriteLine("WHAT WOULD YOU LIKE TO EDIT?");
            string input = Console.ReadLine();

            switch (input) // NEED TO ADD LOOP SO SWITCH KEEPS GOING UNTIL A VALID INPUT IS ENTERED
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
                    if (customerStatus == "ACTIVE" | customerStatus == "INACTIVE")
                    {
                        //change object value
                        Console.WriteLine("CUSTOMER STATUS CHANGE SUCCESSFUL"); 
                    }
                    else
                    {
                        Console.WriteLine("INPUT INVALID. CUSTOMER STATUS CAN ONLY BE ACTIVE OR INACTIVE");
                    }
                    break;
                case "CANCEL":
                    Console.WriteLine("RETURNING TO SEARCH MENU");
                    return false;
                default:
                    Console.WriteLine("INPUT INVALID. ENTER ONE OF THE FOLLOWING:");
                    Console.WriteLine("FIRST NAME, LAST NAME, PHONE NUMBER, EMAIL, ADDRESS, STATUS, CANCEL");
                    break;
            }
            return true;
        }
    }
}
