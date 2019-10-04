namespace BurgerShack.Models
{
    public abstract class MenuItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Calories { get; set; }
        public string Desc { get; set; }

        public virtual string GetTemplate()
        {
            string template = $"¡¡¡ {Title} - {Price:c} - {Calories} calories !!!\n{Desc}\n\n";
            return template;
        }





        public MenuItem(string title, double price, int calories, string desc)
        {
            Title = title;
            Price = price;
            Calories = calories;
            Desc = desc;
        }
    }
}