using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class Branch:BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; }=null!;
        public string Address { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
