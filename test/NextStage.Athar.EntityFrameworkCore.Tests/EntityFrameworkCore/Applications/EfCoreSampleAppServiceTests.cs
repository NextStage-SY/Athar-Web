using NextStage.Athar.Samples;
using Xunit;

namespace NextStage.Athar.EntityFrameworkCore.Applications;

[Collection(AtharTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AtharEntityFrameworkCoreTestModule>
{

}
