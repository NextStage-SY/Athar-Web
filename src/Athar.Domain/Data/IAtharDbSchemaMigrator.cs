using System.Threading.Tasks;

namespace Athar.Data;

public interface IAtharDbSchemaMigrator
{
    Task MigrateAsync();
}
