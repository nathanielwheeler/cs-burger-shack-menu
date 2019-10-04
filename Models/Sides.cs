namespace BurgerShack.Models
{
    public class Sides : MenuItem
    {








        public Sides(string title, double price, string desc) : base(title, price, desc)
        {
            Title = title;
            Price = price;
            Desc = desc;
        }
    }
}