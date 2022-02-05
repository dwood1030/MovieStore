using System;

namespace MovieStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("MOVIES-R-US -- MAIN MENU");
            Console.WriteLine("============================================================");

            bool exit = true;
            while (exit)
            {
                exit = Menu.MainMenu();
            }

            Console.ReadLine();
        }
    }
}
