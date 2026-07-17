using Volo.Abp.Modularity;

namespace Athar;

[DependsOn(
    typeof(AtharDomainModule),
    typeof(AtharTestBaseModule)
)]
public class AtharDomainTestModule : AbpModule
{

}
