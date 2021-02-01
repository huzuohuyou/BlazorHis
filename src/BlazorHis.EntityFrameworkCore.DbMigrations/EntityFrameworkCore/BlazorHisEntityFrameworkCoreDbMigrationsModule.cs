using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace BlazorHis.EntityFrameworkCore
{
    [DependsOn(
        typeof(BlazorHisEntityFrameworkCoreModule)
        )]
    public class BlazorHisEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BlazorHisMigrationsDbContext>();
        }
    }
}
