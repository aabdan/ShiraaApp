using ShiraaAppBlazour.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ShiraaAppBlazour.Blazor;

public abstract class ShiraaAppBlazourComponentBase : AbpComponentBase
{
    protected ShiraaAppBlazourComponentBase()
    {
        LocalizationResource = typeof(ShiraaAppBlazourResource);
    }
}
