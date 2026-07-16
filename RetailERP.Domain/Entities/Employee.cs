using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class Employee:BaseEntity
    {

        public Guid BranchId { get; private set; }
        public Branch Branch { get; private set; } = null!;
        public Guid PositionId { get; private set; } 
        public Position Position { get; private set; }
        public string FirstName { get; private set; } = null!;
        public string LastName { get; private set; } = null!;
        public string EmployeeCode { get; private set; } = null!;
        public DateOnly HireDate { get; private set; }
        public bool IsActive { get; private set; }

        public Employee()
        {
            
        }

        public Employee(
            Guid branchId,
            Guid positionId,
            string firstName, 
            string lastName,
            string employeeCode,
            DateOnly hireDate
            )
        {
            BranchId = branchId;
            PositionId = positionId;
            FirstName = firstName;
            LastName = lastName;
            EmployeeCode = employeeCode;
            HireDate = hireDate;    
            IsActive = true;
        }
        public static Employee Create (Guid branchId,Guid positionId,string firstName,string lastName,string emplyeeCode,DateOnly hireDate)
        {
            return new Employee(branchId, positionId, firstName, lastName, emplyeeCode, hireDate);
        }
        public void Activate()
        {
            IsActive = true;
            SetUpdatedTime();
        }
        public void Deactivate()
        {
            IsActive = false;
            SetUpdatedTime();
        }
    }
}
