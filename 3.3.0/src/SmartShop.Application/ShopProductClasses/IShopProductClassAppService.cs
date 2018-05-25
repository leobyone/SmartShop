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
	/// <summary>
	/// ShopProductClass的应用层服务的接口方法
	/// </summary>
	public interface IShopProductClassAppService : IApplicationService
	{
		/// <summary>
		/// GetShopProductById
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		ShopProductClassDto GetShopProductById(int id);

		/// <summary>
		/// 根据id获取分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task<ShopProductClassDto> GetShopProductClassByIdAsync(EntityDto<int> input);

		/// <summary>
		/// 获取全部的商品分类信息
		/// </summary>
		/// <returns></returns>
		Task<GetAllShopProductClassOutput> GetAllShopProductClasses();

		/// <summary>
		/// 获取商品分类的分页信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task<PagedResultDto<ShopProductClassDto>> GetPagedShopProductClasses(GetShopProductClassesInput input);

		/// <summary>
		/// 添加商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task<CreateShopProductClassInput> CreateShopProductClass(CreateShopProductClassInput input);

		/// <summary>
		/// 更新商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task UpdateShopProductClass(UpdateShopProductClassInput input);

		/// <summary>
		/// 删除商品分类信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		Task DeleteShopProductClass(EntityDto<int> input);
	}
}
