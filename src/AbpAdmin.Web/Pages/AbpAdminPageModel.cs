using AbpAdmin.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpAdmin.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpAdminPageModel : AbpPageModel
    {
        protected AbpAdminPageModel()
        {
            LocalizationResourceType = typeof(AbpAdminResource);
        }
    }
}