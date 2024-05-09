using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShiraaAppBlazour.Data;
using Volo.Abp.DependencyInjection;

namespace ShiraaAppBlazour.EntityFrameworkCore;

public class EntityFrameworkCoreShiraaAppBlazourDbSchemaMigrator
    : IShiraaAppBlazourDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreShiraaAppBlazourDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ShiraaAppBlazourDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ShiraaAppBlazourDbContext>()
            .Database
            .MigrateAsync();
    }
}
