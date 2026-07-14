using RetailERP.Domain.Common;
using RetailERP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class InventoryTransaction : BaseEntity
    {
        public Guid BranchInventoryId { get; private set; }
        public BranchInventory BranchInventory { get; private set; } = null!;
        public InventoryTransactionType Type { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public string? ReferenceCode { get; private set; }
        public string? Source { get; private set; }

        private InventoryTransaction()
        {
        }

        private InventoryTransaction(
             Guid branchInventoryId,
             InventoryTransactionType type,
             int quantity,
             string description,
             string? referenceCode,
             string source

            )
        {
            BranchInventoryId = branchInventoryId;
            Type = type;
            Quantity = quantity;
            Description = description;
            ReferenceCode = referenceCode;
            Source = source;

        }
        public static InventoryTransaction Create()
        {
            return new InventoryTransaction(

                );
        }

    }
}
