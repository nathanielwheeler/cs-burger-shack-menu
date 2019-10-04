using System;
using System.Collections.Generic;
using BurgerShack.Models;
namespace BurgerShack.Services
{
    public class MenuService
    {
        public List<MenuItem> MenuItems { get; private set; }
        public List<string> Messages { get; set; }

        public void Setup()
        {
            Entree nBurger = new Entree("Nathan Burger", 6, "A burger for the discerning gourmand.");
            Entree dBurger = new Entree("Dory Burger", 3, "Half of a Nathan Burger.  The other half has been eaten by Nathan.");
            Entree chicken = new Entree("Chicken Sandwich", 4, "Like a burger, but with chicken.  So not really a burger at all.");

            MenuItems.AddRange(new MenuItem[] { nBurger, dBurger, chicken });
        }





        public MenuService()
        {
            MenuItems = new List<MenuItem>();
            Messages = new List<string>();
            Setup();
        }
    }
}