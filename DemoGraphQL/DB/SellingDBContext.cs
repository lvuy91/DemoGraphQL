using DemoGraphQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoGraphQL.DB
{
    public class SellingDBContext : DbContext
    {
        public SellingDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Generate three GUIDS and place them in an arrays
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            // Apply configuration for the three contexts in our application
            // This will create the demo data for our GraphQL endpoint.
            //builder.ApplyConfiguration(new SuperheroContextConfiguration(ids));
            //builder.ApplyConfiguration(new SuperpowerContextConfiguration(ids));
            //builder.ApplyConfiguration(new MovieContextConfiguration(ids));
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
