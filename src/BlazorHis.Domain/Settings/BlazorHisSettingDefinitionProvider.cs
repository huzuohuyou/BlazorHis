using Volo.Abp.Settings;

namespace BlazorHis.Settings
{
    public class BlazorHisSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BlazorHisSettings.MySetting1));
        }
    }
}
