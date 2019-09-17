using AbpPermissionCacheTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpPermissionCacheTest.Web.Pages
{
    public abstract class AbpPermissionCacheTestPageModel : AbpPageModel
    {
        protected AbpPermissionCacheTestPageModel()
        {
            LocalizationResourceType = typeof(AbpPermissionCacheTestResource);
        }
    }
}