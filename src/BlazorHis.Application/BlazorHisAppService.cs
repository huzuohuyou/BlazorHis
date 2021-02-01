using System;
using System.Collections.Generic;
using System.Text;
using BlazorHis.Localization;
using Volo.Abp.Application.Services;

namespace BlazorHis
{
    /* Inherit your application services from this class.
     */
    public abstract class BlazorHisAppService : ApplicationService
    {
        protected BlazorHisAppService()
        {
            LocalizationResource = typeof(BlazorHisResource);
        }
    }
}
