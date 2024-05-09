using ShiraaAppBlazour.Samples;
using Xunit;

namespace ShiraaAppBlazour.EntityFrameworkCore.Domains;

[Collection(ShiraaAppBlazourTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ShiraaAppBlazourEntityFrameworkCoreTestModule>
{

}
