using System.ComponentModel.DataAnnotations;
using SmartShop.ShopPayOrders.Dtos.LTMAutoMapper;
using SmartShop.Entities;

namespace SmartShop.ShopPayOrders.Dtos
{
	public class ShopPayOrderEditDto
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		public long? Id { get; set; }
		public int? CompanyId { get; set; }
		public int? AdminId { get; set; }
		public string Type { get; set; }
		public string BusinPayType { get; set; }
		public string Scenes { get; set; }
		public string OtherId { get; set; }
		public string OrderNo { get; set; }
		public int? TotalMoney { get; set; }
		public string MchId { get; set; }
		public long ProductId { get; set; }
		public string Body { get; set; }
		public string OpenId { get; set; }
		public int? IsSubscribe { get; set; }
		public string PayNo { get; set; }
		public string CreateDate { get; set; }
		public int? Status { get; set; }
		public string StatusMessage { get; set; }
	}
}