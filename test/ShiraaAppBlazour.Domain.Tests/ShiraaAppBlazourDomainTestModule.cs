using Volo.Abp.Modularity;

namespace ShiraaAppBlazour;

[DependsOn(
    typeof(ShiraaAppBlazourDomainModule),
    typeof(ShiraaAppBlazourTestBaseModule)
)]
public class ShiraaAppBlazourDomainTestModule : AbpModule
{

}
