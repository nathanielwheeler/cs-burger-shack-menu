namespace BurgerShack.Models
{
    public class Entree : MenuItem
    {







        public Entree(string title, double price, string desc) : base(title, price, desc)
        {
            Title = title;
            Price = price;
            Desc = desc;
        }
    }
}