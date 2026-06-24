using Microsoft.EntityFrameworkCore;
using RetailERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Branch> Branches => Set<Branch>();
        public DbSet<SubCompany> SubCompanies => Set<SubCompany>();
        public DbSet<BrandSubCompanyHistory> BrandSubCompanyHistories => Set<BrandSubCompanyHistory>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Configure entity relationships and constraints here if needed

            modelBuilder.Entity<Brand>().HasQueryFilter(x => x.IsDeleted);
            modelBuilder.Entity<Branch>().HasQueryFilter(x => x.IsDeleted);
            modelBuilder.Entity<SubCompany>().HasQueryFilter(x => x.IsDeleted);
            modelBuilder.Entity<BrandSubCompanyHistory>().HasQueryFilter(x => x.IsDeleted);

        }
    }
}
