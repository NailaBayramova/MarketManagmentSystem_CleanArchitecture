using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
   public class Brand:BaseEntity
    {
        //private readonly List<BranchInventory> _branchInventories = [];
        //private readonly List<Employee> _employees = [];
        //public string Name { get; private set; }
        //public string Address { get; private set; }
        //public string PhoneNumber { get; private set; }
        //public bool IsActive { get; private set; }
        //public Guid BrandId { get; private set; }
        //public Brand Brand { get; private set; } = null!;
        private readonly List<Branch> _branches = [];
        private readonly List<Product> _products = [];
        public string Name { get; private set; }

        public bool IsActive { get; private set; }

        public Guid SubCompanyId { get; private set; }

        public SubCompany SubCompany { get; private set; } = null!;


        public IReadOnlyCollection<Branch> Branches => _branches.AsReadOnly();
        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();


        private Brand(string name, Guid subCompanyId)
        {
            Name = name;
            SubCompanyId = subCompanyId;
        }


        public Brand()
        {
            
        }































































    }
}
