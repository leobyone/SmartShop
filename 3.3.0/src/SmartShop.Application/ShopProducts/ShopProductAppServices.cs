using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Linq;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using System.Linq.Dynamic;

using SmartShop.ShopProducts.Dtos;
using SmartShop.Entities;

namespace SmartShop.ShopProducts
{
	/// <summary>
	/// ShopProduct应用层服务的接口实现方法
	/// </summary>

	public class ShopProductAppService : SmartShopAppServiceBase, IShopProductAppService
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		private readonly IRepository<ShopProduct, long> _shopproductRepository;

		/// <summary>
		/// 构造函数
		/// </summary>
		public ShopProductAppService(IRepository<ShopProduct, long> shopproductRepository

			)
		{
			_shopproductRepository = shopproductRepository;

		}

		/// <summary>
		/// 获取ShopProduct的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		//public async Task<PagedResultDto<ShopProductListDto>> GetPagedShopProducts(GetShopProductsInput input)
		//{

		//	var query = _shopproductRepository.GetAll();
		//	//TODO:根据传入的参数添加过滤条件
		//	var shopproductCount = await query.CountAsync();

		//	var shopproducts = await query
		//		.OrderBy(input.Sorting).AsNoTracking()
		//		.PageBy(input)
		//		.ToListAsync();

		//	//var shopproductListDtos = ObjectMapper.Map<List <ShopProductListDto>>(shopproducts);
		//	var shopproductListDtos = shopproducts.MapTo<List<ShopProductListDto>>();

		//	return new PagedResultDto<ShopProductListDto>(
		//		shopproductCount,
		//		shopproductListDtos
		//		);

		//}

		/// <summary>
		/// 通过指定id获取ShopProductListDto信息
		/// </summary>
		public async Task<ShopProductListDto> GetShopProductByIdAsync(EntityDto<long> input)
		{
			var entity = await _shopproductRepository.GetAsync(input.Id);

			return entity.MapTo<ShopProductListDto>();
		}

		/// <summary>
		/// 导出ShopProduct为excel表
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetShopProductsToExcel(){
		//var users = await UserManager.Users.ToListAsync();
		//var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//await FillRoleNames(userListDtos);
		//return _userListExcelExporter.ExportToFile(userListDtos);
		//}
		/// <summary>
		/// MPA版本才会用到的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<GetShopProductForEditOutput> GetShopProductForEdit(NullableIdDto<long> input)
		{
			var output = new GetShopProductForEditOutput();
			ShopProductEditDto shopproductEditDto;

			if (input.Id.HasValue)
			{
				var entity = await _shopproductRepository.GetAsync(input.Id.Value);

				shopproductEditDto = entity.MapTo<ShopProductEditDto>();

				//shopproductEditDto = ObjectMapper.Map<List <shopproductEditDto>>(entity);
			}
			else
			{
				shopproductEditDto = new ShopProductEditDto();
			}

			output.ShopProduct = shopproductEditDto;
			return output;

		}

		/// <summary>
		/// 添加或者修改ShopProduct的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task CreateOrUpdateShopProduct(CreateOrUpdateShopProductInput input)
		{

			if (input.ShopProduct.Id.HasValue)
			{
				await UpdateShopProductAsync(input.ShopProduct);
			}
			else
			{
				await CreateShopProductAsync(input.ShopProduct);
			}
		}

		/// <summary>
		/// 新增ShopProduct
		/// </summary>

		protected virtual async Task<ShopProductEditDto> CreateShopProductAsync(ShopProductEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增
			var entity = ObjectMapper.Map<ShopProduct>(input);

			entity = await _shopproductRepository.InsertAsync(entity);
			return entity.MapTo<ShopProductEditDto>();
		}

		/// <summary>
		/// 编辑ShopProduct
		/// </summary>

		protected virtual async Task UpdateShopProductAsync(ShopProductEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新
			var entity = await _shopproductRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
			await _shopproductRepository.UpdateAsync(entity);
		}

		/// <summary>
		/// 删除ShopProduct信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>

		public async Task DeleteShopProduct(EntityDto<long> input)
		{

			//TODO:删除前的逻辑判断，是否允许删除
			await _shopproductRepository.DeleteAsync(input.Id);
		}

		/// <summary>
		/// 批量删除ShopProduct的方法
		/// </summary>

		public async Task BatchDeleteShopProductsAsync(List<long> input)
		{
			//TODO:批量删除前的逻辑判断，是否允许删除
			await _shopproductRepository.DeleteAsync(s => input.Contains(s.Id));
		}

		public Task<PagedResultDto<ShopProductListDto>> GetPagedShopProducts(GetShopProductsInput input)
		{
			throw new System.NotImplementedException();
		}
	}
}

