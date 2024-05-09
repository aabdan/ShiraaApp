using Volo.Abp.Modularity;

namespace ShiraaAppBlazour;

[DependsOn(
    typeof(ShiraaAppBlazourApplicationModule),
    typeof(ShiraaAppBlazourDomainTestModule)
)]
public class ShiraaAppBlazourApplicationTestModule : AbpModule
{

}
