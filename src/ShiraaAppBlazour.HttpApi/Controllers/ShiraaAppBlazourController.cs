using ShiraaAppBlazour.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShiraaAppBlazour.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShiraaAppBlazourController : AbpControllerBase
{
    protected ShiraaAppBlazourController()
    {
        LocalizationResource = typeof(ShiraaAppBlazourResource);
    }
}
