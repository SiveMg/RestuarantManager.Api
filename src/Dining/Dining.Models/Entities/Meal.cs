namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Meal : BaseModel, IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Ingredients")]
        public long IngredientID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}