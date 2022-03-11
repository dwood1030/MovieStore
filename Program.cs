using System;

namespace MovieStoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
            {
                exit = Menu.MainMenu();
            }

            Console.ReadLine();
        }
    }
}
