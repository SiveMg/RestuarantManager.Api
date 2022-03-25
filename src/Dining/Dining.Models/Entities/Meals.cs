namespace Dining.Models.Entities
{
    public class Meal : BaseModel
    {
        public long MealId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long IngredientID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}