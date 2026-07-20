using Volo.Abp.Modularity;

namespace NextStage.Athar;

[DependsOn(
    typeof(AtharApplicationModule),
    typeof(AtharDomainTestModule)
)]
public class AtharApplicationTestModule : AbpModule
{

}
