using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ShiraaAppBlazour.Blazor;

[Dependency(ReplaceServices = true)]
public class ShiraaAppBlazourBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ShiraaAppBlazour";
}
