using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpAdmin.Data;
using Volo.Abp.DependencyInjection;

namespace AbpAdmin.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpAdminDbSchemaMigrator
        : IAbpAdminDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpAdminDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpAdminMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpAdminMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}