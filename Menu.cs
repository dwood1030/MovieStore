using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp
{
    internal class Menu
    {
        public static bool MainMenu()
        {
            //  offer options to user
            //   - CREATE NEW CUSTOMER
            Console.WriteLine("1. CREATE NEW CUSTOMER");
            //   - CUSTOMER SEARCH
            Console.WriteLine("2. CUSTOMER SEARCH");
            //   - CHECK OUT/RETURN MOVIE
            Console.WriteLine("3. CHECKOUT/RETURN");
            //   - EDIT STOCK
            Console.WriteLine("4. EDIT INVENTORY");
            //  ATTEMPT ERROR HANDLING (user does something i am not expecting)
            Console.WriteLine("5. EXIT");

            Console.Write("ENTER YOUR CHOICE: ");
            // ask for their choice
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    Customers.NewCustomer();
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;

                case "5":
                    return false;

                default:
                    Console.WriteLine($"{userInput} IS INVALID");
                    Console.WriteLine("TRY AGAIN");
                    break;
            }

            return true;
        }
    }
}
