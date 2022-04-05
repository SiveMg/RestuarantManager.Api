namespace Dining.Models.Entities
{
    using Dining.Models.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Table : BaseModel, IEntity
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string TableName { get; set; }
        public string TableDescription { get; set; }
        
    }
}