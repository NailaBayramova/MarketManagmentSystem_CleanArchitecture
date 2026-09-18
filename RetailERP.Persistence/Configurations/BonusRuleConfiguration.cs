
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailERP.Domain.Entities;

namespace RetailERP.Persistence.Configurations
{
   public sealed class BonusRuleConfiguration : IEntityTypeConfiguration<BonusRule>
    {
        public void Configure(EntityTypeBuilder<BonusRule> builder)
        {

        }
    }
}