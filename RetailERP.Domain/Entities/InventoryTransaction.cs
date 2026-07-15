using RetailERP.Domain.Common;
using RetailERP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
             string? source

            )
        {
            BranchInventoryId = branchInventoryId;
            Type = type;
            Quantity = quantity;
            Description = description;
            ReferenceCode = referenceCode;
            Source = source;

        }
        public static InventoryTransaction Create(
            Guid BranchInventoryId,
            InventoryTransactionType Type,
            int Quantity,
            string Description,
            string? ReferenceCode = null,
            string? Source = null)
        {
            return new InventoryTransaction(
                BranchInventoryId,
                Type,
                Quantity,
                Description,
                ReferenceCode,
                Source );
        }
        private void SetQuantity(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            Quantity = quantity;
        }
        private void SetDescription (string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be empty");
            Description = description.Trim();  
        }


    }
}
