using BlazorHis.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BlazorHis
{
    [DependsOn(
        typeof(BlazorHisEntityFrameworkCoreTestModule)
        )]
    public class BlazorHisDomainTestModule : AbpModule
    {

    }
}