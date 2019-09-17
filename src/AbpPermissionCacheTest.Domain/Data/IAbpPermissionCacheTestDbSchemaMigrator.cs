using System.Threading.Tasks;

namespace AbpPermissionCacheTest.Data
{
    public interface IAbpPermissionCacheTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
