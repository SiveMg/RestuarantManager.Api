namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Order : BaseModel
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey("Waitstaff")]
        public long WaitstaffID { get; set; }
        public virtual Waitstaff Waitstaff { get; set; }
        [ForeignKey("Table")]
        public long TableID { get; set; }
        public virtual Table Table { get; set; }
        [Required]
        [ForeignKey("Meals")]
        public long MealID { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
