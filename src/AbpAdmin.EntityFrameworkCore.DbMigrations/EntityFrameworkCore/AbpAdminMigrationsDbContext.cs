using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace AbpAdmin.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See AbpAdminDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class AbpAdminMigrationsDbContext : AbpDbContext<AbpAdminMigrationsDbContext>
    {
        public AbpAdminMigrationsDbContext(DbContextOptions<AbpAdminMigrationsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureFeatureManagement();

            /* Configure your own tables/entities inside the ConfigureAbpAdmin method */

            builder.ConfigureAbpAdmin();
        }
    }
}