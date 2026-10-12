using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{

    public sealed class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

                builder.HasKey(x => x.Id);

                builder.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(x => x.IsActive)
                    .IsRequired();

                builder.HasOne(x => x.SubCompany)
                    .WithMany(x => x.Brands)
                    .HasForeignKey(x => x.SubCompanyId)
                    .OnDelete(DeleteBehavior.Restrict);
            }
        }
    
}
