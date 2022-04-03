namespace Dining.Models
{
    using Dining.Models.Entities;
    using Microsoft.EntityFrameworkCore;
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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Waitstaff>()

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Dev"));
        }

    }
}