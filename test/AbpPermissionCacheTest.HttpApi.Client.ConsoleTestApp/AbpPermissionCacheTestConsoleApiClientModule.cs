using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpPermissionCacheTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpPermissionCacheTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpPermissionCacheTestConsoleApiClientModule : AbpModule
    {
        
    }
}
