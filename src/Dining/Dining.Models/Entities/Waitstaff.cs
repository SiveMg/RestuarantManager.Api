namespace Dining.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Waitstaff : User
    {
        [Key]
        public long WaitstaffId { get; set; }
        public string? PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public long? AddresId { get; set; }
        public Address? Address { get; set;}
    }
}