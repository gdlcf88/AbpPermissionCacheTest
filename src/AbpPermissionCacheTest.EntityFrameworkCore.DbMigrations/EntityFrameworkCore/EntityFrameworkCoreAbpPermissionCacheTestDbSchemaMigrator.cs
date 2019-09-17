using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AbpPermissionCacheTest.Data;
using Volo.Abp.DependencyInjection;

namespace AbpPermissionCacheTest.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAbpPermissionCacheTestDbSchemaMigrator 
        : IAbpPermissionCacheTestDbSchemaMigrator, ITransientDependency
    {
        private readonly AbpPermissionCacheTestMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAbpPermissionCacheTestDbSchemaMigrator(AbpPermissionCacheTestMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}