using Dining.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Dining.Models.Entities
{
    public class Ingredient : BaseModel, IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string IngredientName { get; set; }
        public string IngredientDescription { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
