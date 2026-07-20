using NextStage.Athar.Samples;
using Xunit;

namespace NextStage.Athar.EntityFrameworkCore.Domains;

[Collection(AtharTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AtharEntityFrameworkCoreTestModule>
{

}
