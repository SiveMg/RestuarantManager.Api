namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        [NotMapped]
        public virtual Waitstaff Waitstaff { get; set; }
    }
}