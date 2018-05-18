using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.Authorization
{
	/// <summary>
	/// 定义系统的权限名称的字符串常量。
	/// <see cref="ShopPayOrderAppAuthorizationProvider"/>中对权限的定义.
	/// </summary>
	public static class ShopPayOrderAppPermissions
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION

		/// <summary>
		/// ShopPayOrder管理权限_自带查询授权
		/// </summary>
		public const string ShopPayOrder = "Pages.ShopPayOrder";

		/// <summary>
		/// ShopPayOrder创建权限
		/// </summary>
		public const string ShopPayOrder_CreateShopPayOrder = "Pages.ShopPayOrder.CreateShopPayOrder";
		/// <summary>
		/// ShopPayOrder修改权限
		/// </summary>
		public const string ShopPayOrder_EditShopPayOrder = "Pages.ShopPayOrder.EditShopPayOrder";
		/// <summary>
		/// ShopPayOrder删除权限
		/// </summary>
		public const string ShopPayOrder_DeleteShopPayOrder = "Pages.ShopPayOrder.DeleteShopPayOrder";

		/// <summary>
		/// ShopPayOrder批量删除权限
		/// </summary>
		public const string ShopPayOrder_BatchDeleteShopPayOrders = "Pages.ShopPayOrder.BatchDeleteShopPayOrders";

	}

}

