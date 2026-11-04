using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Repositories.Read_Common
{
    public  interface IReadRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<T?> GetTrackedByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
    }
}
