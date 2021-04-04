using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpAdmin.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpAdminEntityFrameworkCoreModule)
        )]
    public class AbpAdminEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpAdminMigrationsDbContext>();
        }
    }
}
