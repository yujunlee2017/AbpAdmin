using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;

namespace AbpAdmin
{
    [DependsOn(
        typeof(AbpAdminDomainModule),
        typeof(AbpAdminApplicationContractsModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    public class AbpAdminApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpAdminApplicationModule>();
            });
        }
    }
}
