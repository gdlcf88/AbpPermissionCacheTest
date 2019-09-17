using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AbpPermissionCacheTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpPermissionCacheTest.Web.Pages
{
    public abstract class AbpPermissionCacheTestPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpPermissionCacheTestResource> L { get; set; }
    }
}
