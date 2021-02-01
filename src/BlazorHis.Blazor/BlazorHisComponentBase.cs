using BlazorHis.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BlazorHis.Blazor
{
    public abstract class BlazorHisComponentBase : AbpComponentBase
    {
        protected BlazorHisComponentBase()
        {
            LocalizationResource = typeof(BlazorHisResource);
        }
    }
}
