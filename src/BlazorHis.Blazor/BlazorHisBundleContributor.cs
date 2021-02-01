using Volo.Abp.Bundling;

namespace BlazorHis.Blazor
{
    public class BlazorHisBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}