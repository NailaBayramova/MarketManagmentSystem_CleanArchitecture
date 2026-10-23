using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Persistence.Extensions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            //services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            return services;
        }
    }

}
