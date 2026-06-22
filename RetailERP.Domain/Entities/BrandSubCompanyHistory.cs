using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class BrandSubCompanyHistory : BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public int SubCompanyId { get; set; }
        public SubCompany SubCompany { get; set; }= null!;

        public DateTime  StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
