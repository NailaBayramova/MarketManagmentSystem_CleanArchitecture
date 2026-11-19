using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public sealed class InventoryTransactionConfiguration : IEntityTypeConfiguration<InventoryTransaction>
    {
        public void Configure(EntityTypeBuilder<InventoryTransaction> builder)
        {
            builder.ToTable("InventoryTransactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Source)
                   .HasMaxLength(100);

            builder.Property(x => x.Description)
                   .HasMaxLength(300);

            builder.Property(x => x.Type)
                   .IsRequired();

            builder.Property(x => x.ReferenceCode)
                   .HasMaxLength(100);

            builder.Property(x => x.Quantity)
                    .IsRequired();

            builder.HasOne(x => x.BranchInventory)
                   .WithMany(x => x.Transactions)
                   .HasForeignKey(x => x.BranchInventoryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
