using BlazorHis.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BlazorHis.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlazorHisController : AbpController
    {
        protected BlazorHisController()
        {
            LocalizationResource = typeof(BlazorHisResource);
        }
    }
}