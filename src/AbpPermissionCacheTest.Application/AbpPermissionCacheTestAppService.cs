using System;
using System.Collections.Generic;
using System.Text;
using AbpPermissionCacheTest.Localization;
using Volo.Abp.Application.Services;

namespace AbpPermissionCacheTest
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpPermissionCacheTestAppService : ApplicationService
    {
        protected AbpPermissionCacheTestAppService()
        {
            LocalizationResource = typeof(AbpPermissionCacheTestResource);
        }
    }
}
