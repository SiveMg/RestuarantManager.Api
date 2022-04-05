namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;

    public class MealType : BaseModel, IEntity
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string MealTypeName { get; set; }
        public string MealTypeDescription { get; set; }
    }
}