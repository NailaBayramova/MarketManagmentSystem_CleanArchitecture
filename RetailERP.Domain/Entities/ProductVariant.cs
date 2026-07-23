using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class ProductVariant: BaseEntity
    {
        private readonly List<BranchInventory> _branchInventory = [];
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public string Barcode { get; set; } = null!;
        public IReadOnlyCollection<BranchInventory> BranchInventories => _branchInventory.AsReadOnly();

        private ProductVariant()
        {
            
        }
        public ProductVariant(Guid productId, string color, string size, string sku, string barcode)
        {
            ProductId = productId;
            SetColor(color);
            SetSize(size);
            SetSku(sku);
            SetBarcode(barcode);
            
        }
        public static ProductVariant Create (
            
            
           
            
            
            
            
            )
    }
}
