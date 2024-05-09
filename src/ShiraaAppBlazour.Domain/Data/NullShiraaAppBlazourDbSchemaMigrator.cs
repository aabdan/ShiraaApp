using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ShiraaAppBlazour.Data;

/* This is used if database provider does't define
 * IShiraaAppBlazourDbSchemaMigrator implementation.
 */
public class NullShiraaAppBlazourDbSchemaMigrator : IShiraaAppBlazourDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
