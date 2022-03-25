namespace Dining.Models
{
    using Microsoft.EntityFrameworkCore;
    public class RestaurantDiningContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Table> Tables {get; set;}
        public DbSet<Waitstaff> Waitstaff { get; set; }
        

    }
}