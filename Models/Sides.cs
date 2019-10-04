namespace BurgerShack.Models
{
    public class Sides : MenuItem
    {








        public Sides(string title, double price, int calories, string desc) : base(title, price, calories, desc)
        {
            Title = title;
            Price = price;
            Calories = calories;
            Desc = desc;
        }
    }
}