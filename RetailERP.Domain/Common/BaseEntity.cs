using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RetailERP.Domain.Common
{
    public abstract class BaseEntity
    {
        public  Guid Id  { get; protected set; }
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public string? CreatedBy { get; protected set; }

        public DateTime? UpDatedAt { get; protected set; }
        public string? UpDatedBy { get; protected set; }

        public bool IsDeleted { get; protected set; } = false;//mağazadakı məhsulların ilkin olaraq zibil
                                                              //qutusunda yox, birbaşa satışda başlaması
                                                              //üçün bura mütləq = false yazırıq.
        public DateTime? DeletedAt { get; protected set; }
        public string?  DeletedBy { get; protected set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }
        protected void SetUpdateTime()
        {
            UpDatedAt = DateTime.UtcNow;
        }
        protected void MarkAsDeleted()
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }

    }
}
