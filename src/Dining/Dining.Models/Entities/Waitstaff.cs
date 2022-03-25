namespace Dining.Models
{
    public class Waitstaff : User
    {
        public long WaitstaffId { get; set; }
        
        public string? PhoneNumber { get; set; }

        public long? AddresId { get; set; }
        public Address? Address { get; set;}
    }
}