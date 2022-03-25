namespace Dining.Models
{ 
    public class Table : BaseModel
    {
        public long TableId { get; set; }
        public string TableName { get; set; }
        public string TableDescription { get; set; }
    }
}