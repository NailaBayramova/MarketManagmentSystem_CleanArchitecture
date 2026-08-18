using RetailERP.Domain.Common;
using RetailERP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public  class Sale:BaseEntity
    {
        private readonly List<SaleItem> _items = [];
        public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

        public Guid EmployeeId { get; private set; }
        public Employee Employee { get; private set; } = null!;
        public Guid BranchId { get; private set; }
        public Branch Branch { get; private set; } = null!;
        public string InvoiceNumber { get; private set; } = null!;
        public decimal TotalAmount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public DateTime SaleDate { get; private set; }

        public Sale()
        {
            
        }
        private Sale(Guid branchId, Guid employeeId, string invoiceNumber, PaymentMethod paymentMethod)
        {
            BranchId = branchId;
            EmployeeId = employeeId;
            InvoiceNumber = invoiceNumber;
            PaymentMethod = paymentMethod;
            SaleDate = DateTime.UtcNow;
        }

        public static Sale Create(Guid branchId, Guid employeeId, string InvoiceNumber, PaymentMethod paymentMethod)
        {
            return new Sale(branchId, employeeId, InvoiceNumber, paymentMethod);
        }
      public void AddItem()

    }
    
}
