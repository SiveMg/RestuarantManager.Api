namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address : BaseModel
    {
        [Key]
        [Column(Order = 1)]
        public long AddressId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        [Required]
        public string City { get; set; }
        public string Province { get; set; }
        [Required]
        public long PotalCode { get; set; }
        [Required]
        public string Country { get; set; } 
        public virtual Waitstaff Waitstaff { get; set; }
    }
}