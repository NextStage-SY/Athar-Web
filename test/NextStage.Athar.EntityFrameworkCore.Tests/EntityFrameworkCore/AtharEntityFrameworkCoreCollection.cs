using Xunit;

namespace NextStage.Athar.EntityFrameworkCore;

[CollectionDefinition(AtharTestConsts.CollectionDefinitionName)]
public class AtharEntityFrameworkCoreCollection : ICollectionFixture<AtharEntityFrameworkCoreFixture>
{

}
