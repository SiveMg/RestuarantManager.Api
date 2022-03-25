namespace Dining.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MealTypes : BaseModel
    {
        [Key]
        public long MealTypeID { get; set; }
        public string MealTypeName { get; set; }
        public string MealTypeDescription { get; set; }
    }
}