using ShiraaAppBlazour.Samples;
using Xunit;

namespace ShiraaAppBlazour.EntityFrameworkCore.Applications;

[Collection(ShiraaAppBlazourTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ShiraaAppBlazourEntityFrameworkCoreTestModule>
{

}
