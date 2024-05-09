using ShiraaAppBlazour.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ShiraaAppBlazour.Permissions;

public class ShiraaAppBlazourPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ShiraaAppBlazourPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ShiraaAppBlazourPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShiraaAppBlazourResource>(name);
    }
}
