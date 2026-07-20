using Volo.Abp.Modularity;

namespace NextStage.Athar;

[DependsOn(
    typeof(AtharDomainModule),
    typeof(AtharTestBaseModule)
)]
public class AtharDomainTestModule : AbpModule
{

}
