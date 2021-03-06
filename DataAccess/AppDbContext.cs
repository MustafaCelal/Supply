using DataAccess.Configurations;
using DataAccess.Seeds;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{ }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=127.0.0.1,1433; Database=Supply; User Id=SA; Password=Passw0rd"
                //@"Server=(localdb)\mssqllocaldb;Database=Supply;Trusted_Connection=true"
                );
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyDetail> SupplyDetails { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasKey(x=>x.Id);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new SupplyConfiguration());
            modelBuilder.ApplyConfiguration(new SupplyDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentDetailConfiguration());

            modelBuilder.ApplyConfiguration(new ProductSeed());
            modelBuilder.ApplyConfiguration(new CustomerSeed());

        }
    }
}
