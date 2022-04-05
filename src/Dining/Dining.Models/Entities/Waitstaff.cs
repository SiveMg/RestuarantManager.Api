namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Waitstaff : BaseModel, IEntity
    {
        [Key]
       
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public long AddresId { get; set; }
        public Address Address { get; set; }
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}