using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpPermissionCacheTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpPermissionCacheTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpPermissionCacheTest";
    }
}
