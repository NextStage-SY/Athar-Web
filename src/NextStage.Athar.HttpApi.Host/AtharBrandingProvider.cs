using Microsoft.Extensions.Localization;
using NextStage.Athar.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NextStage.Athar;

[Dependency(ReplaceServices = true)]
public class AtharBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AtharResource> _localizer;

    public AtharBrandingProvider(IStringLocalizer<AtharResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
