using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "6'lı Marul Kasa",
                        UnitPrice = 24,
                        UnitsInStock = 100
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "8'li Marul Kasa",
                        UnitPrice = 20,
                        UnitsInStock = 80
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Kara Limon",
                        UnitPrice = 6,
                        UnitsInStock = 30
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Maydanoz",
                        UnitPrice = 1,
                        UnitsInStock = 70
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Nane",
                        UnitPrice = 1,
                        UnitsInStock = 70
                    }                
                );
        }
    
    }
    
}
