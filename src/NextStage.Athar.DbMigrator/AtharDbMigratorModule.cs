using NextStage.Athar.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NextStage.Athar.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AtharEntityFrameworkCoreModule),
    typeof(AtharApplicationContractsModule)
)]
public class AtharDbMigratorModule : AbpModule
{
}
