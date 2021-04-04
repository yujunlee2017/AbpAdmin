using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpAdmin.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpAdminBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpAdmin";
    }
}
