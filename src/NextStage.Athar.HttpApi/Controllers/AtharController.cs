using NextStage.Athar.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NextStage.Athar.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AtharController : AbpControllerBase
{
    protected AtharController()
    {
        LocalizationResource = typeof(AtharResource);
    }
}
