using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Repositories.Write_Common
{
    public interface IWriteRepository <T> where T:BaseEntity
    {
        Task AddSync(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task SaveChangeAsync();
        void Attach(T entity);
    }
}
