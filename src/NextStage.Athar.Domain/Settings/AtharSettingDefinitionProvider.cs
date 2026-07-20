using Volo.Abp.Settings;

namespace NextStage.Athar.Settings;

public class AtharSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AtharSettings.MySetting1));
    }
}
