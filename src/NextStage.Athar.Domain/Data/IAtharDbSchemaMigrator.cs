using System.Threading.Tasks;

namespace NextStage.Athar.Data;

public interface IAtharDbSchemaMigrator
{
    Task MigrateAsync();
}
