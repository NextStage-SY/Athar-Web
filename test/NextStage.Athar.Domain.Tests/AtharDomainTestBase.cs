using Volo.Abp.Modularity;

namespace NextStage.Athar;

/* Inherit from this class for your domain layer tests. */
public abstract class AtharDomainTestBase<TStartupModule> : AtharTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
