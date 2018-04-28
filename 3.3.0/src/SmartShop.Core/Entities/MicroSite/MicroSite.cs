using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Micro_Site
	/// </summary>
	public class MicroSite : AuditedEntity
	{
		/// <summary>
		/// UserId
		/// </summary>
		public virtual int? UserId
		{
			get;
			set;
		}

		/// <summary>
		/// MicroAlbums
		/// </summary>
		public virtual ICollection<MicroAlbum> MicroAlbums
		{
			get;
			set;
		}

		/// <summary>
		/// MicroCoupons
		/// </summary>
		public virtual ICollection<MicroCoupon> MicroCoupons
		{
			get;
			set;
		}

		/// <summary>
		/// IsExp
		/// </summary>
		public virtual int? IsExp
		{
			get;
			set;
		}

		/// <summary>
		/// Name
		/// </summary>
		public virtual string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Logo
		/// </summary>
		public virtual string Logo
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
		/// Phone2
		/// </summary>
		public virtual string Phone2
		{
			get;
			set;
		}

		/// <summary>
		/// Fax
		/// </summary>
		public virtual string Fax
		{
			get;
			set;
		}

		/// <summary>
		/// Lat
		/// </summary>
		public virtual string Lat
		{
			get;
			set;
		}

		/// <summary>
		/// Lng
		/// </summary>
		public virtual string Lng
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
		/// About
		/// </summary>
		public virtual string About
		{
			get;
			set;
		}

		/// <summary>
		/// Service
		/// </summary>
		public virtual string Service
		{
			get;
			set;
		}

		/// <summary>
		/// Industry
		/// </summary>
		public virtual string Industry
		{
			get;
			set;
		}

		/// <summary>
		/// FromKey
		/// </summary>
		public virtual string FromKey
		{
			get;
			set;
		}

		/// <summary>
		/// IsDefault
		/// </summary>
		public virtual int? IsDefault
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
		/// Template
		/// </summary>
		public virtual string Template
		{
			get;
			set;
		}

		/// <summary>
		/// Domain
		/// </summary>
		public virtual string Domain
		{
			get;
			set;
		}

		public MicroSite()
		{

		}
	}
}
