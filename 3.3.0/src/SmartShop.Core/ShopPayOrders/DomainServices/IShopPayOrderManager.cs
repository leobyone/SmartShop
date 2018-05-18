using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.DomainServices
{
	public interface IShopPayOrderManager : IDomainService
	{

		/// <summary>
		/// 初始化方法
		/// </summary>
		void InitShopPayOrder();

	}
}
