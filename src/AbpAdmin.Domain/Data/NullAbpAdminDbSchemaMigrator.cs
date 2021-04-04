using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpAdmin.Data
{
    /* This is used if database provider does't define
     * IAbpAdminDbSchemaMigrator implementation.
     */
    public class NullAbpAdminDbSchemaMigrator : IAbpAdminDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}