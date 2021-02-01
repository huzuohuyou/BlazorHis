using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace BlazorHis.EntityFrameworkCore
{
    public static class BlazorHisDbContextModelCreatingExtensions
    {
        public static void ConfigureBlazorHis(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BlazorHisConsts.DbTablePrefix + "YourEntities", BlazorHisConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}