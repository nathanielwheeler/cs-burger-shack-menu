namespace BurgerShack.Models
{
    public class Drinks : MenuItem
    {







        public Drinks(string title, double price, string desc) : base(title, price, desc)
        {
            Title = title;
            Price = price;
            Desc = desc;
        }
    }
}