using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        public static SubCompany Create(string name)
        {
            return new SubCompany(name);
        }
        public void Activate()
        {
            IsActive = true;
            SetUpdatedTime();
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be  empty ");
            }
            Name = name.Trim();
        }

    }

    
}

