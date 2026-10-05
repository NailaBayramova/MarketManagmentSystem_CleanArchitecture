using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public sealed class BranchInventoryConfiguration : IEntityTypeConfiguration<BranchInventory>
    {
        public void Configure(EntityTypeBuilder<BranchInventory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Quantity);

        }
    }
}
