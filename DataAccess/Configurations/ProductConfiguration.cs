using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(7,2)");

            builder.Property(x => x.UnitsInStock).IsRequired();
            
            builder.ToTable("Products");
        }
    }
}
