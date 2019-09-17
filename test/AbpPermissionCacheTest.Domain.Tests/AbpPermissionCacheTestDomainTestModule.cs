using AbpPermissionCacheTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpPermissionCacheTest
{
    [DependsOn(
        typeof(AbpPermissionCacheTestEntityFrameworkCoreTestModule)
        )]
    public class AbpPermissionCacheTestDomainTestModule : AbpModule
    {

    }
}