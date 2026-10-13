using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
    public sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                    .HasMaxLength(100);

            builder.Property(x => x.LastName)
                    .HasMaxLength(100);

            builder.Property(x => x.IsActive)
                    .IsRequired();
        }
    }
}
