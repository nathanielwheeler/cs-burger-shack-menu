namespace BurgerShack.Models
{
    public class Entree : MenuItem
    {
        public string Ingredients { get; set; }



        public override string GetTemplate()
        {
            return $"¡¡¡ {Title} - {Price:c} - {Calories} calories !!!\n{Desc}\nIngredients: {Ingredients}\n\n";
        }

        public Entree(string title, double price, int calories, string desc, string ingredients) : base(title, price, calories, desc)
        {
            Title = title;
            Price = price;
            Desc = desc;
            Ingredients = ingredients;
        }
    }
}