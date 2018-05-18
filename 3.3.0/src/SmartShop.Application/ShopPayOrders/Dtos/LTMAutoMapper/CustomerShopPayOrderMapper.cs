using AutoMapper;

namespace SmartShop.ShopPayOrders.Dtos.LTMAutoMapper
{
	using SmartShop.Entities;

	/// <summary>
	/// 配置ShopPayOrder的AutoMapper
	/// </summary>
	internal static class CustomerShopPayOrderMapper
	{
		public static void CreateMappings(IMapperConfigurationExpression configuration)
		{
			//    configuration.CreateMap <ShopPayOrder, ShopPayOrderDto>();
			configuration.CreateMap<ShopPayOrder, ShopPayOrderListDto>();
			configuration.CreateMap<ShopPayOrderEditDto, ShopPayOrder>();
			// configuration.CreateMap<CreateShopPayOrderInput, ShopPayOrder>();
			//        configuration.CreateMap<ShopPayOrder, GetShopPayOrderForEditOutput>();
		}
	}
}