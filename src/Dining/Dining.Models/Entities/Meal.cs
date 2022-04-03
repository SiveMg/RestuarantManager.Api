namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Meal : BaseModel
    {
        [Key]
        [Required]
        public long MealId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Ingredients")]
        public long IngredientID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}