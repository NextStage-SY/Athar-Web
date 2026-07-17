using Athar.Samples;
using Xunit;

namespace Athar.EntityFrameworkCore.Domains;

[Collection(AtharTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AtharEntityFrameworkCoreTestModule>
{

}
