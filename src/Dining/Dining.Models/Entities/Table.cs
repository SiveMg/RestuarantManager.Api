namespace Dining.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Table : BaseModel
    {
        [Key]
        public long TableId { get; set; }
        [Required]
        public string TableName { get; set; }
        public string TableDescription { get; set; }
        [ForeignKey("Meals")]
        public long MealID { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}