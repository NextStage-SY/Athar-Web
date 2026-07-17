using Xunit;

namespace Athar.EntityFrameworkCore;

[CollectionDefinition(AtharTestConsts.CollectionDefinitionName)]
public class AtharEntityFrameworkCoreCollection : ICollectionFixture<AtharEntityFrameworkCoreFixture>
{

}
