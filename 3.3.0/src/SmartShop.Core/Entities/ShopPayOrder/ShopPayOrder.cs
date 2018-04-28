using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Shop_PayOrder
	/// </summary>
	public class ShopPayOrder : AuditedEntity<long>
	{
		/// <summary>
		/// CompanyId
		/// </summary>
		public virtual int? CompanyId
		{
			get;
			set;
		}

		/// <summary>
		/// AdminId
		/// </summary>
		public virtual int? AdminId
		{
			get;
			set;
		}

		/// <summary>
		/// Type
		/// </summary>
		public virtual string Type
		{
			get;
			set;
		}

		/// <summary>
		/// BusinPayType
		/// </summary>
		public virtual string BusinPayType
		{
			get;
			set;
		}

		/// <summary>
		/// Scenes
		/// </summary>
		public virtual string Scenes
		{
			get;
			set;
		}

		/// <summary>
		/// OtherId
		/// </summary>
		public virtual string OtherId
		{
			get;
			set;
		}

		/// <summary>
		/// OrderNo
		/// </summary>
		public virtual string OrderNo
		{
			get;
			set;
		}

		/// <summary>
		/// TotalMoney
		/// </summary>
		public virtual int? TotalMoney
		{
			get;
			set;
		}

		/// <summary>
		/// MchId
		/// </summary>
		public virtual string MchId
		{
			get;
			set;
		}

		/// <summary>
		/// ProductId
		/// </summary>
		public virtual long ProductId
		{
			get;
			set;
		}

		[ForeignKey("ProductId")]
		public virtual ShopProduct ShopProduct
		{
			get;
			set;
		}

		/// <summary>
		/// Body
		/// </summary>
		public virtual string Body
		{
			get;
			set;
		}

		/// <summary>
		/// OpenId
		/// </summary>
		public virtual string OpenId
		{
			get;
			set;
		}

		/// <summary>
		/// IsSubscribe
		/// </summary>
		public virtual int? IsSubscribe
		{
			get;
			set;
		}

		/// <summary>
		/// PayNo
		/// </summary>
		public virtual string PayNo
		{
			get;
			set;
		}

		/// <summary>
		/// CreateDate
		/// </summary>
		public virtual string CreateDate
		{
			get;
			set;
		}

		/// <summary>
		/// Status
		/// </summary>
		public virtual int? Status
		{
			get;
			set;
		}

		/// <summary>
		/// StatusMessage
		/// </summary>
		public virtual string StatusMessage
		{
			get;
			set;
		}

		public ShopPayOrder()
		{

		}
	}
}
