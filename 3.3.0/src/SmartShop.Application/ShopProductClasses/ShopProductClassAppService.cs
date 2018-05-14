using Abp.AutoMapper;
using Abp.Domain.Repositories;
using SmartShop.Entities;
using SmartShop.ShopProductClasses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses
{
	public class ShopProductClassAppService : SmartShopAppServiceBase,IShopProductClassAppService
	{
		private readonly IRepository<ShopProductClass> _shopProductClassRepository;

		public ShopProductClassAppService(IRepository<ShopProductClass> shopProductClassRepository)
		{
			_shopProductClassRepository = shopProductClassRepository;
		}

		public async Task<GetAllShopProductClassOutput> GetAllShopProductClasses()
		{
			var shopProductClasses = await _shopProductClassRepository.GetAllListAsync();

			return new GetAllShopProductClassOutput
			{
				ShopProductClasses = shopProductClasses.MapTo<List<ShopProductClassDto>>()
			};
		}
	}
}
