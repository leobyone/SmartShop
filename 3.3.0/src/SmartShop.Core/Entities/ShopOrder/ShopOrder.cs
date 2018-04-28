using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Shop_Order
	/// </summary>
	public class ShopOrder : AuditedEntity<long>
	{
		/// <summary>
		/// MemberId
		/// </summary>
		public virtual int? MemberId
		{
			get;
			set;
		}

		/// <summary>
		/// CompanyId
		/// </summary>
		public virtual int? CompanyId
		{
			get;
			set;
		}

		/// <summary>
		/// OrderType
		/// </summary>
		public virtual int? OrderType
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
		/// Fee
		/// </summary>
		public virtual decimal? Fee
		{
			get;
			set;
		}

		/// <summary>
		/// OriginalFee
		/// </summary>
		public virtual decimal? OriginalFee
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
		/// Phone
		/// </summary>
		public virtual string Phone
		{
			get;
			set;
		}

		/// <summary>
		/// UserName
		/// </summary>
		public virtual string UserName
		{
			get;
			set;
		}

		/// <summary>
		/// Address
		/// </summary>
		public virtual string Address
		{
			get;
			set;
		}

		/// <summary>
		/// Remarks
		/// </summary>
		public virtual string Remarks
		{
			get;
			set;
		}

		/// <summary>
		/// IsUse
		/// </summary>
		public virtual int? IsUse
		{
			get;
			set;
		}

		/// <summary>
		/// IsRefund
		/// </summary>
		public virtual int? IsRefund
		{
			get;
			set;
		}

		/// <summary>
		/// IsRemove
		/// </summary>
		public virtual int? IsRemove
		{
			get;
			set;
		}

		/// <summary>
		/// PayType
		/// </summary>
		public virtual int? PayType
		{
			get;
			set;
		}

		/// <summary>
		/// PayStatus
		/// </summary>
		public virtual int? PayStatus
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

		/// <summary>
		/// CreateDate
		/// </summary>
		public virtual string CreateDate
		{
			get;
			set;
		}

		public ShopOrder()
		{

		}
	}
}
