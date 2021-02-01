using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BlazorHis.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class BlazorHisBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BlazorHis";
    }
}
