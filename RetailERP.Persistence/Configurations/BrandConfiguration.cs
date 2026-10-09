using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public class BrandConfiguration
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                            .IsRequired()
                            .HasMaxLength(100);

            builder.Property(x => x.IsActive)
                             .IsRequired();

            builder.Property(x => x.SubCompany)
                            .IsRequired();
            builder.HasOne
                

        }          
    }
}
