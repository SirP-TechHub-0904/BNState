using BNState.Domain.Services.AWS;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNState.Domain
{

    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Lojour Data services to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection AddInternalDataServices(this IServiceCollection services)
        {

            services.AddTransient<IStorageService, StorageService>();

            return services;

        }
    }
}
