using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlazorHis.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BlazorHisMigrationsDbContextFactory : IDesignTimeDbContextFactory<BlazorHisMigrationsDbContext>
    {
        public BlazorHisMigrationsDbContext CreateDbContext(string[] args)
        {
            BlazorHisEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BlazorHisMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BlazorHisMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BlazorHis.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
