namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Order : BaseModel, IEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [ForeignKey("Waitstaff")]
        public long WaitstaffID { get; set; }
        public virtual Waitstaff Waitstaff { get; set; }
        [ForeignKey("Table")]
        public long TableID { get; set; }
        public virtual Table Table { get; set; }
        
    }
}
