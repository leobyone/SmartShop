using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using SmartShop.Authorization;
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

		public Task<PagedResultDto<GetAllShopProductClassOutput>> GetPagedShopProductClasses()
		{
			throw new NotImplementedException();
		}

		public async Task<GetAllShopProductClassOutput> GetAllShopProductClasses()
		{
			var shopProductClasses = await _shopProductClassRepository.GetAllListAsync();

			return new GetAllShopProductClassOutput
			{
				ShopProductClasses = shopProductClasses.MapTo<List<ShopProductClassDto>>()
			};
		}

		public async Task<CreateShopProductClassDto> Create(CreateShopProductClassDto input)
		{
			var entity = ObjectMapper.Map<ShopProductClass>(input);

			entity = await _shopProductClassRepository.InsertAsync(entity);

			return entity.MapTo<CreateShopProductClassDto>();
		}

		public async Task Update(ShopProductClassDto input)
		{
			var entity = await _shopProductClassRepository.GetAsync(input.Id);

			input.MapTo(entity);

			await _shopProductClassRepository.UpdateAsync(entity);
		}

		public async Task DeleteShopProductClass(EntityDto<int> input)
		{
			await _shopProductClassRepository.DeleteAsync(input.Id);
		}
	}
}
