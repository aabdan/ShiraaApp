using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ShiraaAppBlazour.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ShiraaAppBlazourDbContextFactory : IDesignTimeDbContextFactory<ShiraaAppBlazourDbContext>
{
    public ShiraaAppBlazourDbContext CreateDbContext(string[] args)
    {
        ShiraaAppBlazourEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ShiraaAppBlazourDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ShiraaAppBlazourDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ShiraaAppBlazour.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
