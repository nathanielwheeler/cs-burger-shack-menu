using System;
using BurgerShack.Controllers;

namespace BurgerShack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MenuController mc = new MenuController();
            System.Console.WriteLine(@"
¡¡¡ Welcome to Nathan's Burger Shack !!!

Exit with Q.  Otherwise, press any key to continue.
            ");
            bool running = false;
            if (Console.ReadLine().ToLower() == "q")
            {
                running = false;
            }
            else
            {
                running = true;
            }

            while (running)
            {
                running = mc.GetUserInput();
            }
            Environment.Exit(1);
        }
    }
}
