using System;
using BurgerShack.Services;

namespace BurgerShack.Controllers
{
    public class MenuController
    {
        private MenuService _ms { get; set; } = new MenuService();
        public bool Start()
        {
            return GetUserInput();
        }

        public bool GetUserInput()
        {
            Console.Clear();

            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "q":
                    return false;
                default:
                    System.Console.WriteLine("Invalid Command");
                    return true;
            }
        }

        private void Print()
        {
            foreach (string message in _ms.Messages)
            {
                System.Console.WriteLine(message);
            }
            _ms.Messages.Clear();
            System.Console.WriteLine();
        }






    }
}