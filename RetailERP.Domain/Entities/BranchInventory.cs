using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class BranchInventory
    {
        private readonly List<InventoryTransaction> _transactions = [];

        public Guid ProductVariantId { get;private set; }
        public ProductVariant ProductVariant { get; private set; } = null!;
        public Guid  BranchId { get;private set; }
        public Branch Branch { get; private set; } = null!;
        public int  Quantity { get;private set; }
        public int MinimumStockLevel { get;private set; }
        public bool  IsSelleing { get; set; }

        public IReadOnlyCollection<InventoryTransaction> Transactions => _transactions;

        private BranchInventory() { }

        private BranchInventory(
            Guid productVariantId,
            Guid branchId,
            int  quantity,
            int minimumStockLevel
            )
        {
            SetQuantity(quantity);
            SetMinimumStockLevel(minimumStockLevel);
            ProductVariantId = productVariantId;
            BranchId = branchId;
            IsSelleing = true;


        }
        public static BranchInventory Create(
               Guid productId,
               Guid branchId,
               int  quantity,
               int  minimumStockLevel
            )
        {
            return new BranchInventory(
                productId,
                branchId,
                quantity,
                minimumStockLevel );
        }

        private InventoryTransaction IncreaseStock(int quantity, InventoryTransactionType type, string  description, string? source )
    }
}
