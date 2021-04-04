using Volo.Abp.Settings;

namespace AbpAdmin.Settings
{
    public class AbpAdminSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpAdminSettings.MySetting1));
        }
    }
}
