namespace Dining.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BaseModel
    {
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public User CreatedBy { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
        [Required]
        public User ModifiedBy { get; set; }
    }
}