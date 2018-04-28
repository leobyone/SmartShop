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
	/// Shop_OrderDealRecord
	/// </summary>
	public class ShopOrderDealRecord : CreationAuditedEntity
	{
		/// <summary>
		/// OrderId
		/// </summary>
		public virtual int? OrderId
		{
			get;
			set;
		}

		[ForeignKey("OrderId")]
		public virtual ShopOrder ShopOrder
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
		/// AdminName
		/// </summary>
		public virtual string AdminName
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

		public ShopOrderDealRecord()
		{

		}
	}
}
