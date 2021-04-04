using AbpAdmin.Organization;
using AbpAdmin.System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpAdmin.EntityFrameworkCore
{
    public static class AbpAdminDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpAdmin(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpAdminConsts.DbTablePrefix + "YourEntities", AbpAdminConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            builder.Entity<Department>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Department", AbpAdminConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                //b.HasOne<Department>().WithMany().HasForeignKey(x => x.AuthorId).IsRequired();
            });

            builder.Entity<News>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "News",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<Position>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Position",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<User>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "User",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<UserBelong>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "UserBelong",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<Area>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Area",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<Dict>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Dict",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<DictDetail>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "DictDetail",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<LoginLog>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "LoginLog",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<Menu>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Menu",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<MenuAuthorize>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "MenuAuthorize",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
            builder.Entity<Role>(b =>
            {
                b.ToTable(AbpAdminConsts.DbTablePrefix + "Role",
                    AbpAdminConsts.DbSchema);

                b.ConfigureByConvention();
            });
        }
    }
}