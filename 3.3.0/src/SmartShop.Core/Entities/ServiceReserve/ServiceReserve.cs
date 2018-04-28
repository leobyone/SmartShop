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
	/// ServiceReserve
	/// </summary>
	public class ServiceReserve : AuditedEntity
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
		/// Type
		/// </summary>
		public virtual string Type
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
		/// Phone
		/// </summary>
		public virtual string Phone
		{
			get;
			set;
		}

		/// <summary>
		/// City
		/// </summary>
		public virtual string City
		{
			get;
			set;
		}

		/// <summary>
		/// District
		/// </summary>
		public virtual string District
		{
			get;
			set;
		}

		/// <summary>
		/// AccessDate
		/// </summary>
		public virtual string AccessDate
		{
			get;
			set;
		}

		/// <summary>
		/// AccessTime
		/// </summary>
		public virtual string AccessTime
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

		public ServiceReserve()
		{

		}
	}
}
