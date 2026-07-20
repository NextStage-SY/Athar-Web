using Volo.Abp.Modularity;

namespace NextStage.Athar;

public abstract class AtharApplicationTestBase<TStartupModule> : AtharTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
