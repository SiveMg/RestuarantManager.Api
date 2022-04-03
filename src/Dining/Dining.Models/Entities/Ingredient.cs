using System.ComponentModel.DataAnnotations;

namespace Dining.Models.Entities
{
    public class Ingredient
    {
        [Key]
        [Required]
        public long IngredientId { get; set; }
        [Required]
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
