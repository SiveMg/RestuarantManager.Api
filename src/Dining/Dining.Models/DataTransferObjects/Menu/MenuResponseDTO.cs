namespace Dining.Models.DataTransferObjects
{
    public class MenuResponseDTO
    {
        public IEnumerable<MenuItem> menuItems { get; set; }
    }

    public class MenuItem
    {
        public string MealName { get; set; }
        public IEnumerable<IngredientDTO> Ingredients { get; set; }
    }
}
