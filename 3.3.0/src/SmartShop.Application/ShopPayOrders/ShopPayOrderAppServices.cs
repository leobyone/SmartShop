using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Linq;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using System.Linq.Dynamic;
using SmartShop.ShopPayOrders.Authorization;
using SmartShop.ShopPayOrders.Dtos;
using SmartShop.ShopPayOrders.DomainServices;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders
{
	/// <summary>
	/// ShopPayOrder应用层服务的接口实现方法
	/// </summary>
	[AbpAuthorize(ShopPayOrderAppPermissions.ShopPayOrder)]
	public class ShopPayOrderAppService : SmartShopAppServiceBase, IShopPayOrderAppService
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		private readonly IRepository<ShopPayOrder, long> _shoppayorderRepository;
		private readonly IShopPayOrderManager _shoppayorderManager;

		/// <summary>
		/// 构造函数
		/// </summary>
		public ShopPayOrderAppService(IRepository<ShopPayOrder, long> shoppayorderRepository
	  , IShopPayOrderManager shoppayorderManager
		)
		{
			_shoppayorderRepository = shoppayorderRepository;
			_shoppayorderManager = shoppayorderManager;
		}

		/// <summary>
		/// 获取ShopPayOrder的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		//public async Task<PagedResultDto<ShopPayOrderListDto>> GetPagedShopPayOrders(GetShopPayOrdersInput input)
		//{

		//	var query = _shoppayorderRepository.GetAll();
		//	//TODO:根据传入的参数添加过滤条件
		//	var shoppayorderCount = await query.CountAsync();

		//	var shoppayorders = await query
		//		.OrderBy(input.Sorting).AsNoTracking()
		//		.PageBy(input)
		//		.ToListAsync();

		//	//var shoppayorderListDtos = ObjectMapper.Map<List <ShopPayOrderListDto>>(shoppayorders);
		//	var shoppayorderListDtos = shoppayorders.MapTo<List<ShopPayOrderListDto>>();

		//	return new PagedResultDto<ShopPayOrderListDto>(
		//		shoppayorderCount,
		//		shoppayorderListDtos
		//		);

		//}

		/// <summary>
		/// 通过指定id获取ShopPayOrderListDto信息
		/// </summary>
		public async Task<ShopPayOrderListDto> GetShopPayOrderByIdAsync(EntityDto<long> input)
		{
			var entity = await _shoppayorderRepository.GetAsync(input.Id);

			return entity.MapTo<ShopPayOrderListDto>();
		}

		/// <summary>
		/// 导出ShopPayOrder为excel表
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetShopPayOrdersToExcel(){
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
		public async Task<GetShopPayOrderForEditOutput> GetShopPayOrderForEdit(NullableIdDto<long> input)
		{
			var output = new GetShopPayOrderForEditOutput();
			ShopPayOrderEditDto shoppayorderEditDto;

			if (input.Id.HasValue)
			{
				var entity = await _shoppayorderRepository.GetAsync(input.Id.Value);

				shoppayorderEditDto = entity.MapTo<ShopPayOrderEditDto>();

				//shoppayorderEditDto = ObjectMapper.Map<List <shoppayorderEditDto>>(entity);
			}
			else
			{
				shoppayorderEditDto = new ShopPayOrderEditDto();
			}

			output.ShopPayOrder = shoppayorderEditDto;
			return output;

		}

		/// <summary>
		/// 添加或者修改ShopPayOrder的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task CreateOrUpdateShopPayOrder(CreateOrUpdateShopPayOrderInput input)
		{

			if (input.ShopPayOrder.Id.HasValue)
			{
				await UpdateShopPayOrderAsync(input.ShopPayOrder);
			}
			else
			{
				await CreateShopPayOrderAsync(input.ShopPayOrder);
			}
		}

		/// <summary>
		/// 新增ShopPayOrder
		/// </summary>
		[AbpAuthorize(ShopPayOrderAppPermissions.ShopPayOrder_CreateShopPayOrder)]
		protected virtual async Task<ShopPayOrderEditDto> CreateShopPayOrderAsync(ShopPayOrderEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增
			var entity = ObjectMapper.Map<ShopPayOrder>(input);

			entity = await _shoppayorderRepository.InsertAsync(entity);
			return entity.MapTo<ShopPayOrderEditDto>();
		}

		/// <summary>
		/// 编辑ShopPayOrder
		/// </summary>
		[AbpAuthorize(ShopPayOrderAppPermissions.ShopPayOrder_EditShopPayOrder)]
		protected virtual async Task UpdateShopPayOrderAsync(ShopPayOrderEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新
			var entity = await _shoppayorderRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);

			// ObjectMapper.Map(input, entity);
			await _shoppayorderRepository.UpdateAsync(entity);
		}

		/// <summary>
		/// 删除ShopPayOrder信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ShopPayOrderAppPermissions.ShopPayOrder_DeleteShopPayOrder)]
		public async Task DeleteShopPayOrder(EntityDto<long> input)
		{

			//TODO:删除前的逻辑判断，是否允许删除
			await _shoppayorderRepository.DeleteAsync(input.Id);
		}

		/// <summary>
		/// 批量删除ShopPayOrder的方法
		/// </summary>
		[AbpAuthorize(ShopPayOrderAppPermissions.ShopPayOrder_BatchDeleteShopPayOrders)]
		public async Task BatchDeleteShopPayOrdersAsync(List<long> input)
		{
			//TODO:批量删除前的逻辑判断，是否允许删除
			await _shoppayorderRepository.DeleteAsync(s => input.Contains(s.Id));
		}

		public Task<PagedResultDto<ShopPayOrderListDto>> GetPagedShopPayOrders(GetShopPayOrdersInput input)
		{
			throw new System.NotImplementedException();
		}
	}
}

