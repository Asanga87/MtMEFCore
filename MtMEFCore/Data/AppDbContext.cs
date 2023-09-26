using Microsoft.EntityFrameworkCore;
using MtMEFCore.Models;

namespace MtMEFCore.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)  
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer_Shop>().HasKey(cs => new
            {
                cs.ShopID,
                cs.CustomerID

            });

            modelBuilder.Entity<Customer_Shop>().HasOne(c => c.Customer).WithMany(cs => cs.customer_Shops).HasForeignKey
                (c => c.CustomerID);

            modelBuilder.Entity<Customer_Shop>().HasOne(c => c.Shop).WithMany(cs => cs.customer_Shops).HasForeignKey
                (c => c.ShopID);


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Customer_Shop> Customer_Shops { get; set; }
    }
}
