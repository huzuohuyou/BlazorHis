using BlazorHis.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BlazorHis.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BlazorHisEntityFrameworkCoreDbMigrationsModule),
        typeof(BlazorHisApplicationContractsModule)
        )]
    public class BlazorHisDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
