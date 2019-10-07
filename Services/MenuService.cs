using System;
using System.Collections.Generic;
using BurgerShack.Models;
namespace BurgerShack.Services
{
    public class MenuService
    {
        public List<MenuItem> MenuItems { get; private set; }
        public List<string> Messages { get; set; }
        public Dictionary<MenuItem, int> Order { get; set; }

        public void Setup()
        {
            Entree nBurger = new Entree("Nathan Burger", 6, 900, "A double-patty burger for the most discerning of gourmands.", "Caramelized onions, pickles, and spicy brown mustard.");
            Entree dBurger = new Entree("Dory Burger", 3, 450, "Half of a Nathan Burger.  The other half has been eaten by Nathan.", "Caramelized onions, pickles, and spicy brown mustard.");
            Entree lBurger = new Entree("Laura Burger", 5, 600, "An aggressively homosexual burger.", "Saurkraut, pickles, and yellow mustard.");
            Entree chicken = new Entree("Chicken Sandwich", 4, 500, "Like a burger, but with chicken.  So not really like a burger at all.", "Lettuce and mayo.");

            MenuItems.AddRange(new MenuItem[] { nBurger, dBurger, lBurger, chicken });
        }

        public void GetMenuItems()
        {
            Messages.Add("!!! Nathan's Burger Shack Menu!!!\n");
            for (int i = 0; i < MenuItems.Count; i++)
            {
                MenuItem m = MenuItems[i];
                Messages.Add($"{i + 1}. {m.Title}: {m.Price:c} - {m.Calories} calories");
            }
            Messages.Add("Enter number to view item.\nEnter Q to quit.");
        }
        internal void GetMenuItems(int index)
        {
            if (index < MenuItems.Count && index > -1)
            {
                MenuItem item = MenuItems[index];
                Messages.Add(item.GetTemplate());
                Messages.Add("\nEnter 'A' to add to order.");

                if (Order.ContainsKey(MenuItems[index]))
                {
                    Messages.Add("Enter 'R' to remove from order.");
                }
            }
            else
            {
                Messages.Add("Invalid Choice... Baka!");
            }
        }

        // Add to Order.
        public void AddToOrder(int MenuItemIndex, int quantity)
        {
            MenuItem m = MenuItems[MenuItemIndex];
            Order.Add(m, quantity);
        }

        // Display all items in checkout and show the price total
        public void Checkout()
        {
            Messages.Add("\tCheckout\n");
            double orderTotal = 0;
            foreach (KeyValuePair<MenuItem, int> item in Order)
            {
                // Multiplies item price by quantity ordered, then adds this information to Messages
                orderTotal += item.Key.Price * item.Value;
                Messages.Add($"{item.Key.Title} x{item.Value} — {item.Key.Price:c * item.Value}");
            }
            Messages.Add($"\n\n\tTotal:\t{orderTotal:c}");
        }



        public MenuService()
        {
            MenuItems = new List<MenuItem>();
            Messages = new List<string>();
            Setup();
        }
    }
}