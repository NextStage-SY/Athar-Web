using Athar.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Athar.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AtharEntityFrameworkCoreModule),
    typeof(AtharApplicationContractsModule)
)]
public class AtharDbMigratorModule : AbpModule
{
}
