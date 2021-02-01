using BlazorHis.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BlazorHis.Permissions
{
    public class BlazorHisPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BlazorHisPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BlazorHisPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BlazorHisResource>(name);
        }
    }
}
