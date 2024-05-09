using System.Threading.Tasks;

namespace ShiraaAppBlazour.Data;

public interface IShiraaAppBlazourDbSchemaMigrator
{
    Task MigrateAsync();
}
