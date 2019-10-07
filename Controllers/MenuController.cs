using System;
using BurgerShack.Services;

namespace BurgerShack.Controllers
{
    public class MenuController
    {
        private MenuService _ms { get; set; } = new MenuService();

        public bool GetUserInput()
        {
            _ms.GetMenuItems();
            Print();
            string choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "q":
                    return false;
                default:
                    if (int.TryParse(choice, out int index))
                    {
                        // Prints menu item details
                        _ms.GetMenuItems(index - 1);
                        Print();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Command");
                    }
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