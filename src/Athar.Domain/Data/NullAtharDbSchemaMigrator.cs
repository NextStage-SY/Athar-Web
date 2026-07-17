using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Athar.Data;

/* This is used if database provider does't define
 * IAtharDbSchemaMigrator implementation.
 */
public class NullAtharDbSchemaMigrator : IAtharDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
