using System.Threading.Tasks;

namespace BlazorHis.Data
{
    public interface IBlazorHisDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
