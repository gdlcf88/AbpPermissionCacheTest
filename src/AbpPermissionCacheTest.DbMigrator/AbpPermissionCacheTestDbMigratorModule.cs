using AbpPermissionCacheTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpPermissionCacheTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpPermissionCacheTestEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpPermissionCacheTestApplicationContractsModule)
        )]
    public class AbpPermissionCacheTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<BackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
