using AbpPermissionCacheTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpPermissionCacheTest.Permissions
{
    public class AbpPermissionCacheTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpPermissionCacheTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpPermissionCacheTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpPermissionCacheTestResource>(name);
        }
    }
}
