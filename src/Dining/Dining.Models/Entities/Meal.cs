namespace Dining.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Meal : BaseModel
    {
        [Key]
        public long MealId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public long IngredientID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}