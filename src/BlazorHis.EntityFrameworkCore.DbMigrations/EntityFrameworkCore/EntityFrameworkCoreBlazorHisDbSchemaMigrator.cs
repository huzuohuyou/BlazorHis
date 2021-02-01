using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlazorHis.Data;
using Volo.Abp.DependencyInjection;

namespace BlazorHis.EntityFrameworkCore
{
    public class EntityFrameworkCoreBlazorHisDbSchemaMigrator
        : IBlazorHisDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBlazorHisDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BlazorHisMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BlazorHisMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}