using System;
using System.Collections.Generic;
using System.Text;
using AbpAdmin.Localization;
using Volo.Abp.Application.Services;

namespace AbpAdmin
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpAdminAppService : ApplicationService
    {
        protected AbpAdminAppService()
        {
            LocalizationResource = typeof(AbpAdminResource);
        }
    }
}
