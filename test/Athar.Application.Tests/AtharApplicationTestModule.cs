using Volo.Abp.Modularity;

namespace Athar;

[DependsOn(
    typeof(AtharApplicationModule),
    typeof(AtharDomainTestModule)
)]
public class AtharApplicationTestModule : AbpModule
{

}
