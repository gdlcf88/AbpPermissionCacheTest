using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpPermissionCacheTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpPermissionCacheTestEntityFrameworkCoreModule)
        )]
    public class AbpPermissionCacheTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpPermissionCacheTestMigrationsDbContext>();
        }
    }
}
