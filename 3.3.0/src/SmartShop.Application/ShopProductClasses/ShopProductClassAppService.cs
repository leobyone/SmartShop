using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using SmartShop.Entities;
using SmartShop.ShopProductClasses.Dtos;

namespace SmartShop.ShopProductClasses
{
	/// <summary>
	/// ShopProductClass应用层服务的接口实现方法
	/// </summary>
	public class ShopProductClassAppService : SmartShopAppServiceBase,IShopProductClassAppService
	{
		private readonly IRepository<ShopProductClass, int> _shopProductClassRepository;

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="shopProductClassRepository"></param>
		public ShopProductClassAppService(IRepository<ShopProductClass, int> shopProductClassRepository)
		{
			_shopProductClassRepository = shopProductClassRepository;
		}

		/// <summary>
		/// 获取商品分类分页信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<PagedResultDto<ShopProductClassDto>> GetPagedShopProductClasses(GetShopProductClassesInput input)
		{
			//初步过滤
			var query = _shopProductClassRepository.GetAll()
				.WhereIf(!input.Filter.IsNullOrEmpty(), t=>t.ClassName.Contains(input.Filter));

			//获取总数
			var shopProductClassCount = await query.CountAsync();

			//ABP提供了扩展方法PageBy分页方式
			var shopProductClasses = await query
				.OrderBy(input.Sorting).AsNoTracking()
				.PageBy(input)
				.ToListAsync();

			var shopProductClassListDtos = shopProductClasses.MapTo<List<ShopProductClassDto>>();

			return new PagedResultDto<ShopProductClassDto>(shopProductClassCount, shopProductClassListDtos);
		}

		/// <summary>
		/// 获取全部的商品分类信息
		/// </summary>
		/// <returns></returns>
		public async Task<GetAllShopProductClassOutput> GetAllShopProductClasses()
		{
			var shopProductClasses = await _shopProductClassRepository.GetAllListAsync();

			return new GetAllShopProductClassOutput
			{
				ShopProductClasses = shopProductClasses.MapTo<List<ShopProductClassDto>>()
			};
		}

		/// <summary>
		/// 添加商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<CreateShopProductClassInput> CreateShopProductClass(CreateShopProductClassInput input)
		{
			var entity = ObjectMapper.Map<ShopProductClass>(input);

			entity = await _shopProductClassRepository.InsertAsync(entity);

			return entity.MapTo<CreateShopProductClassInput>();
		}

		/// <summary>
		/// 更新商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task UpdateShopProductClass(UpdateShopProductClassInput input)
		{
			var entity = await _shopProductClassRepository.GetAsync(input.Id);

			input.MapTo(entity);

			await _shopProductClassRepository.UpdateAsync(entity);
		}

		/// <summary>
		/// 删除商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task DeleteShopProductClass(EntityDto<int> input)
		{
			await _shopProductClassRepository.DeleteAsync(input.Id);
		}

		/// <summary>
		/// 根据id获取分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<ShopProductClassDto> GetShopProductClassByIdAsync(EntityDto<int> input)
		{
			var entity = await _shopProductClassRepository.GetAsync(input.Id);

			return entity.MapTo<ShopProductClassDto>();
		}

		/// <summary>
		/// GetShopProductById
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ShopProductClassDto GetShopProductById(int id)
		{
			var entity = _shopProductClassRepository.Get(id);

			return entity.MapTo<ShopProductClassDto>();
		}
	}
}
