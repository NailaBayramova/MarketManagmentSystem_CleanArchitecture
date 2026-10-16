using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Configurations
{
   public  sealed class SaleCofiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure (EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.InvoiceNumber)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.TotalAmount)
                   .HasPrecision(18, 2)
                   .IsRequired();

            builder.HasOne(x => x.Employee)
                 .WithMany()
                 .HasForeignKey(x => x.EmployeeId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
