using Athar.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Athar.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AtharController : AbpControllerBase
{
    protected AtharController()
    {
        LocalizationResource = typeof(AtharResource);
    }
}
