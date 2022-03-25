namespace Dining.Models
{
    using System.ComponentModel.DataAnnotations;
    public class User: BaseModel
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