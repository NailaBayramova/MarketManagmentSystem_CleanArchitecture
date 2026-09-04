using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class SubCompany: BaseEntity
    {
        private readonly List<Brand> _brands = [];
        public string Name { get; private set; } = null;
        public bool IsActive { get; private set; } = true;

        private IReadOnlyCollection<Brand> Brands => _brands.AsReadOnly();
        public SubCompany()
        {
            
        }
        private SubCompany(string name)
        {
            SetName(name);
            IsActive = true;
        }

    }

    
}

