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

        static List<Customer> customerList = new List<Customer>();
        
        public static void NewCustomer()
        {

            string jsonString = File.ReadAllText(@"..\..\..\customerList.json");
            var customer = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;

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
            customerList.AddRange(customer);

            string json = JsonSerializer.Serialize(customerList);
            File.WriteAllText(@"..\..\..\customerList.json", json);
        }

        public static bool CustomerSearch()
        {
            string jsonString = File.ReadAllText(@"..\..\..\customerList.json");
            var customer = JsonSerializer.Deserialize<List<Customer>>(jsonString)!;

            Console.Write("ENTER CUSTOMER NAME: ");
            string search = Console.ReadLine();

            //IEnumerable<Customer> can also be written in place of var queryAllCustomers
            var queryAllCustomers = from cust in customer
                                    where cust.Name == search
                                    select cust;

            int index = 0;
            bool isNumber = false;
            int selectedIndex = 0;

            foreach(Customer cust in queryAllCustomers)
            {
                Console.WriteLine($"Index: {index} \nName: {cust.Name} \nBirthday: {cust.Birthday} \nEmail: {cust.Email} \nPhone Number: {cust.PhoneNumber} \nAddress: {cust.Address} \nStatus: {cust.Status}\n");
                index++;
            }
            
            Console.WriteLine("PLEASE SELECT THE CUSTOMER INDEX USING '0', '1','2','3', ETC..");

            while (isNumber == false)
            {
                string inputIndex = Console.ReadLine();

                if(!int.TryParse(inputIndex, out selectedIndex))
                {
                    Console.WriteLine("INPUT INVALID. PLEASE ENTER A VALID INDEX.");
                }
                else
                {
                    isNumber = true;
                }
            }

            if (selectedIndex < index++ && selectedIndex > -1)
            {
                var selectedCustomer = queryAllCustomers.ElementAt(selectedIndex);
                Console.WriteLine("WOULD YOU LIKE TO EDIT THIS CUSTOMER? INPUT 'Y' OR 'N'");
                string edit = Console.ReadLine();
                Console.WriteLine();

                switch (edit)
                {
                    case "Y":
                        EditCustomer(selectedCustomer);
                        break;

                    case "N":
                        Console.WriteLine("RETURNING TO MAIN MENU");
                        return false;

                    default:
                        Console.WriteLine("INPUT INVALID.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("INPUT INVALID");
            }

            string json = JsonSerializer.Serialize(customer);
            File.WriteAllText(@"..\..\..\customerList.json", json);

            return false;
        }

        public static bool EditCustomer(Customer selectedCustomer)
        {
            Console.WriteLine("WHAT WOULD YOU LIKE TO EDIT?");
            Console.WriteLine("PLEASE SELECT FIRST NAME, LAST NAME, PHONE NUMBER, EMAIL, ADDRESS, OR STATUS");
            string input = Console.ReadLine();

            switch (input)
            {
                case "FIRST NAME":
                    Console.WriteLine("PLEASE ENTER NEW FIRST NAME");
                    selectedCustomer.FirstName = Console.ReadLine();
                    selectedCustomer.Name = selectedCustomer.FirstName + " " + selectedCustomer.LastName;
                    break;

                case "LAST NAME":
                    Console.WriteLine("PLEASE ENTER NEW LAST NAME");
                    selectedCustomer.LastName = Console.ReadLine();
                    selectedCustomer.Name = selectedCustomer.FirstName + " " + selectedCustomer.LastName;
                    break;

                case "PHONE NUMBER":
                    Console.WriteLine("PLEASE ENTER NEW PHONE NUMBER");
                    selectedCustomer.PhoneNumber = Console.ReadLine();
                    break;

                case "EMAIL":
                    Console.WriteLine("PLEASE ENTER NEW EMAIL");
                    selectedCustomer.Email = Console.ReadLine();
                    break;

                case "ADDRESS":
                    Console.WriteLine("PLEASE ENTER NEW ADDRESS");
                    selectedCustomer.Address = Console.ReadLine();
                    break;

                case "STATUS":
                    Console.WriteLine("PLEASE ENTER NEW CUSTOMER STATUS");
                    Console.WriteLine("CUSTOMER STATUS CAN ONLY BE ACTIVE OR INACTIVE");
                    string customerStatus = Console.ReadLine();

                    if (customerStatus == "ACTIVE" | customerStatus == "INACTIVE")
                    {
                        selectedCustomer.Status = customerStatus;
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
