namespace BurgerShack.Models
{
    public class Drinks : MenuItem
    {







        public Drinks(string title, double price, int calories, string desc) : base(title, price, calories, desc)
        {
            Title = title;
            Price = price;
            Calories = calories;
            Desc = desc;
        }
    }
}