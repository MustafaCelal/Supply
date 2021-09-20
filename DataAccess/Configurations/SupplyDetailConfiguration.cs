using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class SupplyDetailConfiguration : IEntityTypeConfiguration<SupplyDetail>
    {
        public void Configure(EntityTypeBuilder<SupplyDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.SupplyId).IsRequired();
            
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(7,2)");
            
            builder.ToTable("SupplyDetails");
        }
    }
}
