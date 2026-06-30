using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class Branch:BaseEntity
    {
        private readonly List<BranchInventory> _branchInventories = []; 
        private readonly List<Employee> _employees = [];
        public string Name { get; private set; }
        public string Address { get; private set; }
        public  string PhoneNumber { get; private set; }
        public bool IsActive { get; private set; }
        public Brand Brand  { get; private  set; }
        public Guid  BrandId { get; set; }

        public IReadOnlyCollection<BranchInventory> BranchInventories => _branchInventories.AsReadOnly();
        public IReadOnlyCollection<Employee> Employees => _employees.AsReadOnly();

        private Branch()
        {
            // Required by EF Core
        }
        private Branch (
            string name,
            string address, 
            string phoneNumber,
            Guid brandId)
        {
            SetName(name);
            SetAddress(address);
            SetPhoneNumber(phoneNumber);
            IsActive = true;
            BrandId = brandId;
        }

        public static Branch Create (
            string name,
            string address,
            string phoneNumber,
            Guid brandId)
        {
            return new Branch(
                name, 
                address,
                phoneNumber,
                brandId);

        }

        public void Activate()
        {
            IsActive = true;
            SetUpdateTime();
        }   
        public void Deactivate()
        {
            IsActive = false;
            SetUpdateTime();
        }

        public void UpDateName( string name )
        {
            SetName(name);
            SetUpdateTime();
        }

        public void UpDateAddress(string address)
        {
            SetAddress(address);
            SetUpdateTime();
        }
        public void UpDatePhoneNumber(string phoneNumber)
        {
            SetPhoneNumber(phoneNumber);
            SetUpdateTime();
        }
        public void Delete()
        {
            MarkAsDeleted();
            SetUpdateTime();
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Branch name cannot be empty.");
            Name = name.Trim();
        }

        private void SetAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Branch address cannot be empty.");
            Address = address.Trim();
        }
        private void SetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Branch phone number cannot be empty.");
            PhoneNumber = phoneNumber.Trim();
        }
    }
}
