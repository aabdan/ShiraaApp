using ShiraaAppBlazour.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ShiraaAppBlazour.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShiraaAppBlazourEntityFrameworkCoreModule),
    typeof(ShiraaAppBlazourApplicationContractsModule)
    )]
public class ShiraaAppBlazourDbMigratorModule : AbpModule
{
}
