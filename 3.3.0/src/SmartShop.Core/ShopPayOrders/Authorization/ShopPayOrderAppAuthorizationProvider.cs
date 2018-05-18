using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using SmartShop.Authorization;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.Authorization
{
	/// <summary>
	/// 权限配置都在这里。
	/// 给权限默认设置服务
	/// See <see cref="ShopPayOrderAppPermissions"/> for all permission names.
	/// </summary>
	//public class ShopPayOrderAppAuthorizationProvider : AuthorizationProvider
	//{
	//	////BCC/ BEGIN CUSTOM CODE SECTION
	//	////ECC/ END CUSTOM CODE SECTION
	//	public override void SetPermissions(IPermissionDefinitionContext context)
	//	{
	//		//在这里配置了ShopPayOrder 的权限。
	//		var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

	//		var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration)
	//						?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

	//		var shoppayorder = administration.CreateChildPermission(ShopPayOrderAppPermissions.ShopPayOrder, L("ShopPayOrder"));
	//		shoppayorder.CreateChildPermission(ShopPayOrderAppPermissions.ShopPayOrder_CreateShopPayOrder, L("CreateShopPayOrder"));
	//		shoppayorder.CreateChildPermission(ShopPayOrderAppPermissions.ShopPayOrder_EditShopPayOrder, L("EditShopPayOrder"));
	//		shoppayorder.CreateChildPermission(ShopPayOrderAppPermissions.ShopPayOrder_DeleteShopPayOrder, L("DeleteShopPayOrder"));
	//		shoppayorder.CreateChildPermission(ShopPayOrderAppPermissions.ShopPayOrder_BatchDeleteShopPayOrders, L("BatchDeleteShopPayOrders"));

	//	}

	//	private static ILocalizableString L(string name)
	//	{
	//		return new LocalizableString(name, SmartShopConsts.LocalizationSourceName);
	//	}
	//}

}