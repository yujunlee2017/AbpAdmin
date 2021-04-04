using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace AbpAdmin.IdentityServer
{
    public class IdentityServerDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private readonly IConfiguration _configuration;
        private readonly ICurrentTenant _currentTenant;

        public IdentityServerDataSeedContributor(
            IGuidGenerator guidGenerator,
            IConfiguration configuration,
            ICurrentTenant currentTenant)
        {
            _guidGenerator = guidGenerator;
            _configuration = configuration;
            _currentTenant = currentTenant;
        }

        [UnitOfWork]
        public virtual async Task SeedAsync(DataSeedContext context)
        {
            using (_currentTenant.Change(context?.TenantId))
            {
            }
        }
    }
}
