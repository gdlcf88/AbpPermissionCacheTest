using AbpPermissionCacheTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpPermissionCacheTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpPermissionCacheTestController : AbpController
    {
        protected AbpPermissionCacheTestController()
        {
            LocalizationResource = typeof(AbpPermissionCacheTestResource);
        }
    }
}