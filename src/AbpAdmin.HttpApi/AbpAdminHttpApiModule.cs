using Localization.Resources.AbpUi;
using AbpAdmin.Localization;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace AbpAdmin
{
    [DependsOn(
        typeof(AbpAdminApplicationContractsModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    public class AbpAdminHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AbpAdminResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}
