using Volo.Abp.Modularity;

namespace AbpPermissionCacheTest
{
    [DependsOn(
        typeof(AbpPermissionCacheTestApplicationModule),
        typeof(AbpPermissionCacheTestDomainTestModule)
        )]
    public class AbpPermissionCacheTestApplicationTestModule : AbpModule
    {

    }
}