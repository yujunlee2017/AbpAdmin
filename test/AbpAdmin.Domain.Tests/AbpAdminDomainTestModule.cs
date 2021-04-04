using AbpAdmin.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpAdmin
{
    [DependsOn(
        typeof(AbpAdminEntityFrameworkCoreTestModule)
        )]
    public class AbpAdminDomainTestModule : AbpModule
    {

    }
}