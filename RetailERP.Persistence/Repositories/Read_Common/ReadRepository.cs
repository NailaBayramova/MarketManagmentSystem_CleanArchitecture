using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Repositories.Read_Common
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        protected readonly RetailERPDbContext Context;

        public ReadRepository(RetailERPDbContext context)
        {
            Context = context;
        }
    }
