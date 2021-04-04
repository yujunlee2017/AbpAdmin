using AbpAdmin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpAdmin.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpAdminController : AbpController
    {
        protected AbpAdminController()
        {
            LocalizationResource = typeof(AbpAdminResource);
        }
    }
}