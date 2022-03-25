namespace Dining.Models
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        public string IngredientName { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
