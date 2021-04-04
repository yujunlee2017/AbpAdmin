using System.Threading.Tasks;
using AbpAdmin.Localization;
using AbpAdmin.MultiTenancy;
using Volo.Abp.UI.Navigation;

namespace AbpAdmin.Web.Menus
{
    public class AbpAdminMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //if (!MultiTenancyConsts.IsEnabled)
            //{
            //    var administration = context.Menu.GetAdministration();
            //    administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            //}

            var l = context.GetLocalizer<AbpAdminResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(AbpAdminMenus.Home, l["Menu:Home"], "~/"));
        }
    }
}
