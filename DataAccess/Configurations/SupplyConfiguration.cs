using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class SupplyConfiguration : IEntityTypeConfiguration<Supply>
    {
        public void Configure(EntityTypeBuilder<Supply> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.SupplyDate).IsRequired();
            
            builder.Property(x => x.TotalPrice).HasColumnType("decimal(7,2)");

            builder.ToTable("Supplies");
        }
    }
}
