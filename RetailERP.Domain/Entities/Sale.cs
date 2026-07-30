using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public  class Sale:BaseEntity
    {
        public Guid  EmployeeId { get;private set; }
        public Employee Employee { get; private set; }
        public Guid BranchId { get;private set; }
        public Branch Branch { get;private set; }
        public string  InvoiceNumber { get;private set; }
        public DateTime SaleDate { get; set; }
    }
}
