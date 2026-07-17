using Volo.Abp.Modularity;

namespace Athar;

public abstract class AtharApplicationTestBase<TStartupModule> : AtharTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
