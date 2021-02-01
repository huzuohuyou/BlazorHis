using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BlazorHis.Data
{
    /* This is used if database provider does't define
     * IBlazorHisDbSchemaMigrator implementation.
     */
    public class NullBlazorHisDbSchemaMigrator : IBlazorHisDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}