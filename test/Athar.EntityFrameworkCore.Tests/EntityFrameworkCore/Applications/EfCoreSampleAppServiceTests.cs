using Athar.Samples;
using Xunit;

namespace Athar.EntityFrameworkCore.Applications;

[Collection(AtharTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AtharEntityFrameworkCoreTestModule>
{

}
