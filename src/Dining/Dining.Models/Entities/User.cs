namespace Dining.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Key]
        [Required]
        public long UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public virtual Waitstaff Waitstaff { get; set; }
    }
}