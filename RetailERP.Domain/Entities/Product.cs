using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class Product:BaseEntity
    {
        private readonly List<ProductVariant> _productVariants = [];
        private readonly List<BranchInventory> _branchInventories = [];

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public string Barcode { get; private set; }

        public bool IsActive { get; private set; }

        public Guid BrandId { get; private set; }

        public Brand Brand { get; private set; } = null!;

        public IReadOnlyCollection<BranchInventory> BranchInventories => _branchInventories.AsReadOnly();
        public IReadOnlyCollection<ProductVariant> ProductVariants => _productVariants.AsReadOnly();


        private Product()
        {
            
        }
        private Product(string name, decimal price, string barcode, string description, Guid brandId)
        {
            SetName(name);

            SetDescription(description);

            SetPrice(price);

            SetBarcode(barcode);

            BrandId = brandId;

            IsActive = true;

        }
        public static Product Create (string name, decimal price, string barcode, string description, Guid brandId)
        {
            return new Product(
                name,
                price,
                barcode,
                description,
                brandId);
        }
        public  void Activate()
        {
            IsActive = true;
            SetUpdatedTime();
        }
        public void Deactivate()
        {
            IsActive = false;
            SetUpdatedTime();
        }
        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(" Product Name cannot be empty");
            }
            Name = name;
        }
        private void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be empty");
            }
            Description = description.Trim();
        }
        private void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Price must be  greater than zero");

               
            }
            Price = price;
        }
    }
}
