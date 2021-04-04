using Volo.Abp.Modularity;

namespace AbpAdmin
{
    [DependsOn(
        typeof(AbpAdminApplicationModule),
        typeof(AbpAdminDomainTestModule)
        )]
    public class AbpAdminApplicationTestModule : AbpModule
    {

    }
}