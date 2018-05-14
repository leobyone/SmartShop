using Abp.Application.Services;
using SmartShop.ShopProductClasses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses
{
	public interface IShopProductClassAppService : IApplicationService
	{
		Task<GetAllShopProductClassOutput> GetAllShopProductClasses();
	}
}
