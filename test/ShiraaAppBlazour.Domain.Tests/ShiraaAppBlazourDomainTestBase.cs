using Volo.Abp.Modularity;

namespace ShiraaAppBlazour;

/* Inherit from this class for your domain layer tests. */
public abstract class ShiraaAppBlazourDomainTestBase<TStartupModule> : ShiraaAppBlazourTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
