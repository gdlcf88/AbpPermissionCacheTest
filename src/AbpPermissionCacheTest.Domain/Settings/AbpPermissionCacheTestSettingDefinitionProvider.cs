using Volo.Abp.Settings;

namespace AbpPermissionCacheTest.Settings
{
    public class AbpPermissionCacheTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpPermissionCacheTestSettings.MySetting1));
        }
    }
}
