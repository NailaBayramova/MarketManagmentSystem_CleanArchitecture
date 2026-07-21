using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class EmployeeTransfer : BaseEntity
    {
        public Guid  EmployeeId { get; private set; }

        public Guid OldBranchId { get; private set; }
        public Guid NewBranchId { get; private set; }

        public Guid OldPositionId { get; private set; }
        public Guid  NewPositionId { get; private set; }

        public DateOnly TransferDate { get; private set; }
     
        public string? Reason { get; private set; }

        private EmployeeTransfer()
        {
            
        }
        public EmployeeTransfer(
            Guid employeeId,
            Guid oldBranchId,
            Guid newBranchId,
            Guid oldPositionId,
            Guid  newPositionId,
            DateOnly transferDate,
            string? reason
            )
        {
            EmployeeId = employeeId;
            OldBranchId = oldBranchId;
            NewBranchId = newBranchId;
            OldPositionId = oldPositionId;
            NewPositionId = newPositionId;
            TransferDate = transferDate;
            Reason = reason;

            
        }
        public static EmployeeTransfer Create(
             Guid employeeId,
            Guid oldBranchId,
            Guid newBranchId,
            Guid oldPositionId,
            Guid newPositionId,
            DateOnly transferDate,
            string? reason
            )
        {
            return new EmployeeTransfer(employeeId, oldBranchId, newBranchId, oldPositionId, newPositionId, transferDate, reason);
        }
    }
}



























