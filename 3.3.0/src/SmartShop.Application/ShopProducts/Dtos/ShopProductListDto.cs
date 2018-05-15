using System;
using Abp.Application.Services.Dto;
using SmartShop.ShopProducts.Dtos.LTMAutoMapper;
using SmartShop.Entities;

namespace SmartShop.ShopProducts.Dtos
{
	public class ShopProductListDto : AuditedEntityDto<long>
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		public int CompanyId { get; set; }
		public string ProductNo { get; set; }
		public int CategoryId { get; set; }
		public string Mode { get; set; }
		public string ProductType { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Background { get; set; }
		public string Cover { get; set; }
		public string ImageList { get; set; }
		public string Templet { get; set; }
		public int? CanCount { get; set; }
		public int? ValidityDay { get; set; }
		public string Unit { get; set; }
		public decimal OrigPrice { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public int Sales { get; set; }
		public int IsRecommend { get; set; }
		public int IsHot { get; set; }
		public int IsTop { get; set; }
		public int SortId { get; set; }
		public string Summary { get; set; }
		public string Detail { get; set; }
		public int IsRemove { get; set; }
		public int IsActivity { get; set; }
		public int Status { get; set; }
		public string StatusMessage { get; set; }
	}
}