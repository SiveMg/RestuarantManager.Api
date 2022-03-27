namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Waitstaff : BaseModel
    {
        [Key]
        public long WaitstaffId { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public long AddresId { get; set; }
        public Address Address { get; set; }
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}