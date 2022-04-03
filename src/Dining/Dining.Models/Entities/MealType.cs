namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class MealType : BaseModel
    {
        [Key]
        public long MealTypeID { get; set; }
        [Required]
        public string MealTypeName { get; set; }
        public string MealTypeDescription { get; set; }
    }
}