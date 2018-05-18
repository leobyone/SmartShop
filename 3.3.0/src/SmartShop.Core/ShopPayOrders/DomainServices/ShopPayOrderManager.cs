using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.DomainServices
{
	/// <summary>
	/// ShopPayOrder领域层的业务管理
	/// </summary>
	public class ShopPayOrderManager : SmartShopDomainServiceBase, IShopPayOrderManager
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		private readonly IRepository<ShopPayOrder, long> _shoppayorderRepository;
		/// <summary>
		/// ShopPayOrder的构造方法
		/// </summary>
		public ShopPayOrderManager(IRepository<ShopPayOrder, long> shoppayorderRepository)
		{
			_shoppayorderRepository = shoppayorderRepository;
		}

		//TODO:编写领域业务代码
		/// <summary>
		///     初始化
		/// </summary>
		public void InitShopPayOrder()
		{
			throw new NotImplementedException();
		}

	}

}
