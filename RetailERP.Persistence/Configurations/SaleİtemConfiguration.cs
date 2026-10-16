using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public sealed  class SaleİtemConfiguration : IEntityTypeConfiguration <SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.UnitPrice)
                .HasPrecision(18, 2);

            builder.Property(x => x.TotalPrice)
                .HasPrecision(18, 2);

            builder.Property(x => x.Quantity)
                .IsRequired();
        }
    }
}
