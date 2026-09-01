using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class SaleItem : BaseEntity
    {
        public Guid SaleId { get; private set; }
        public Sale Sale { get; private set; } = null!;
        public string ProductName { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Guid ProductVariantId { get; private set; }
        public string Color { get; private set; }
        public string Size { get; private set; }
        public string SKU { get; private set; }

        public SaleItem()
        {
            
        }

        private SaleItem(Guid productVariantId,
            string productName,
            decimal unitPrice,
            int quantity,
            string color,
            string size,
            string sku)
        {
            ProductVariantId = productVariantId;
            ProductName = productName;
            Color = color;
            Size = size;
            SKU = sku;
            SetUnitPrice(unitPrice);
            SetQuantity(quantity);
            CalculateTotalPrice();
        }
    }
}
