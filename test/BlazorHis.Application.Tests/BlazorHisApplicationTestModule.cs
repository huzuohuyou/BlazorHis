using Volo.Abp.Modularity;

namespace BlazorHis
{
    [DependsOn(
        typeof(BlazorHisApplicationModule),
        typeof(BlazorHisDomainTestModule)
        )]
    public class BlazorHisApplicationTestModule : AbpModule
    {

    }
}