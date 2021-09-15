﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class OrderPayDetailConfiguration : IEntityTypeConfiguration<OrderPayDetail>
    {
        public void Configure(EntityTypeBuilder<OrderPayDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.PreviousDept).IsRequired().HasColumnType("decimal(7,2)");

            builder.Property(x => x.RecievedMoney).IsRequired().HasColumnType("decimal(7,2)");
            
            builder.Property(x => x.LastDept).IsRequired().HasColumnType("decimal(7,2)");

            builder.ToTable("OrderPayDetails");

        }
    }
}
