namespace Dining.Models
{
    using System;
    public class BaseModel
    {
        public DateTime CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public User ModifiedBy { get; set; }
    }
}