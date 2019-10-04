namespace BurgerShack.Models
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }

        public virtual string GetTemplate()
        {
            string template = $"¡¡¡ {Title} - {Price:c} !!!\n{Desc}\n\n";
            return template;
        }





        public MenuItem(string title, double price, string desc)
        {
            Title = title;
            Price = price;
            Desc = desc;
        }
    }
}