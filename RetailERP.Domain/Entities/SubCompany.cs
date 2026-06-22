using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class SubCompany: BaseEntity
    {
        public string  Name { get; set; }=string.Empty;
        public bool IsActive { get; set; } = true;

        public ICollection<BrandSubCompanyHistory> BrandHistories { get; set; } = new List<BrandSubCompanyHistory>();
    }
}
