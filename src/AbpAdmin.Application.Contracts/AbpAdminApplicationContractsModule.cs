using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace AbpAdmin
{
    [DependsOn(
        typeof(AbpAdminDomainSharedModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpObjectExtendingModule)
    )]
    public class AbpAdminApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AbpAdminDtoExtensions.Configure();
        }
    }
}
