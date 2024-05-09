using System;
using System.Collections.Generic;
using System.Text;
using ShiraaAppBlazour.Localization;
using Volo.Abp.Application.Services;

namespace ShiraaAppBlazour;

/* Inherit your application services from this class.
 */
public abstract class ShiraaAppBlazourAppService : ApplicationService
{
    protected ShiraaAppBlazourAppService()
    {
        LocalizationResource = typeof(ShiraaAppBlazourResource);
    }
}
