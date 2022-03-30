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
            Console.WriteLine("============================================================");
            Console.WriteLine("MOVIES-R-US -- MAIN MENU");
            Console.WriteLine("============================================================");
          
            Console.WriteLine("1. CREATE NEW CUSTOMER");
         
            Console.WriteLine("2. CUSTOMER SEARCH");
        
            //Console.WriteLine("3. CHECKOUT");

            //Console.WriteLine("4. RETURN");
            
            //Console.WriteLine("5. VIEW INVENTORY");
            
            Console.WriteLine("6. EXIT");

            Console.Write("ENTER YOUR CHOICE: ");
            
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1": // CREATE NEW CUSTOMER
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();

                    Customer.NewCustomer();

                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;

                case "2": // CUSTOMER SEARCH
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    bool exitSearch = true;
                    while (exitSearch)
                    {
                        exitSearch = Customer.CustomerSearch();
                    }
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;

                //case "3": // CHECK OUT
                //    Console.WriteLine();
                //    Console.WriteLine("============================================================");
                //    Console.WriteLine();
                //    break;

                //case "4": // RETURN
                //    Console.WriteLine();
                //    Console.WriteLine("============================================================");
                //    Console.WriteLine();
                //    break;

                //case "5": // VIEW INVENTORY
                //    Console.WriteLine();
                //    Console.WriteLine("============================================================");
                //    Console.WriteLine();

                //    Movies.ViewInventory();

                //    Console.WriteLine();
                //    Console.WriteLine("============================================================");
                //    Console.WriteLine();
                //    break;

                case "6": // EXIT APPLICATION
                    return false;

                default:
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    Console.WriteLine($"{userInput} IS INVALID");
                    Console.WriteLine("TRY AGAIN");
                    Console.WriteLine();
                    Console.WriteLine("============================================================");
                    Console.WriteLine();
                    break;
            }

            return true;
        }
    }
}
