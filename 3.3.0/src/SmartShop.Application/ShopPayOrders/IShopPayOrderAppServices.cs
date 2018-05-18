using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartShop.ShopPayOrders.Dtos;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders
{
	/// <summary>
	/// ShopPayOrder应用层服务的接口方法
	/// </summary>
	public interface IShopPayOrderAppService : IApplicationService
	{
		/// <summary>
		/// 获取ShopPayOrder的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task<PagedResultDto<ShopPayOrderListDto>> GetPagedShopPayOrders(GetShopPayOrdersInput input);

		/// <summary>
		/// 通过指定id获取ShopPayOrderListDto信息
		/// </summary>
		Task<ShopPayOrderListDto> GetShopPayOrderByIdAsync(EntityDto<long> input);

		/// <summary>
		/// 导出ShopPayOrder为excel表
		/// </summary>
		/// <returns></returns>
		//  Task<FileDto> GetShopPayOrdersToExcel();
		/// <summary>
		/// MPA版本才会用到的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task<GetShopPayOrderForEditOutput> GetShopPayOrderForEdit(NullableIdDto<long> input);

		//todo:缺少Dto的生成GetShopPayOrderForEditOutput
		/// <summary>
		/// 添加或者修改ShopPayOrder的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task CreateOrUpdateShopPayOrder(CreateOrUpdateShopPayOrderInput input);

		/// <summary>
		/// 删除ShopPayOrder信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task DeleteShopPayOrder(EntityDto<long> input);

		/// <summary>
		/// 批量删除ShopPayOrder
		/// </summary>
		Task BatchDeleteShopPayOrdersAsync(List<long> input);
	}
}
