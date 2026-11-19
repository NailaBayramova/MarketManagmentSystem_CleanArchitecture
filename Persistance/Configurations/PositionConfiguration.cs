using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public sealed class PositionConfiguration: IEntityTypeConfiguration<Position>
    {
        
            public void Configure(EntityTypeBuilder<Position> builder)
            {
                builder.ToTable("Positions");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(x => x.IsActive)
                    .IsRequired();

                builder.HasIndex(x => x.Name)
                    .IsUnique();
            }
        
    }
}
