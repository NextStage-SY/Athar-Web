using NextStage.Athar.Localization;
using Volo.Abp.Application.Services;

namespace NextStage.Athar;

/* Inherit your application services from this class.
 */
public abstract class AtharAppService : ApplicationService
{
    protected AtharAppService()
    {
        LocalizationResource = typeof(AtharResource);
    }
}
