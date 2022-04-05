namespace Dining.Models
{
    using Dining.Models.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class RestaurantDiningContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Table> Tables {get; set;}
        public DbSet<Waitstaff> Waitstaff { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }  
        public DbSet<MealType> MealTypes { get; set; }  
        public DbSet<Order> Orders { get; set; }

    }
}