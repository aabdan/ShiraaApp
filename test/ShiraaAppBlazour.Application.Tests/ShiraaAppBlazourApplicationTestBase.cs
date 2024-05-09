using Volo.Abp.Modularity;

namespace ShiraaAppBlazour;

public abstract class ShiraaAppBlazourApplicationTestBase<TStartupModule> : ShiraaAppBlazourTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
