using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpPermissionCacheTest.Data
{
    /* This is used if database provider does't define
     * IAbpPermissionCacheTestDbSchemaMigrator implementation.
     */
    public class NullAbpPermissionCacheTestDbSchemaMigrator : IAbpPermissionCacheTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}