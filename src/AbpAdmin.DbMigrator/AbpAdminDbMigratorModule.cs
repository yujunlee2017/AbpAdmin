using AbpAdmin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpAdmin.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAdminEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAdminApplicationContractsModule)
        )]
    public class AbpAdminDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
