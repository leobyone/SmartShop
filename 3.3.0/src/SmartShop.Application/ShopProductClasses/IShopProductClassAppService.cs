using Abp.Application.Services;
using Abp.Application.Services.Dto;
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

		Task<PagedResultDto<GetAllShopProductClassOutput>> GetPagedShopProductClasses();

		Task<CreateShopProductClassDto> Create(CreateShopProductClassDto input);

		Task Update(ShopProductClassDto input);

		Task DeleteShopProductClass(EntityDto<int> input);
	}
}
