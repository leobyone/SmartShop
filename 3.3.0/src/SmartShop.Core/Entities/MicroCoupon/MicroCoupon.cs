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
	/// Micro_Coupon
	/// </summary>
	public class MicroCoupon : CreationAuditedEntity
	{
		/// <summary>
		/// SiteId
		/// </summary>
		public virtual int? SiteId
		{
			get;
			set;
		}

		/// <summary>
		/// MicroSite
		/// </summary>
		[ForeignKey("SiteId")]
		public virtual MicroSite MicroSite
		{
			get;
			set;
		}

		/// <summary>
		/// Title
		/// </summary>
		public virtual string Title
		{
			get;
			set;
		}

		/// <summary>
		/// Remark
		/// </summary>
		public virtual string Remark
		{
			get;
			set;
		}

		public MicroCoupon()
		{

		}
	}
}
