using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Case
	/// </summary>
	public class Case : CreationAuditedEntity
	{
		/// <summary>
		/// Name
		/// </summary>
		public virtual string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Summary
		/// </summary>
		public virtual string Summary
		{
			get;
			set;
		}

		/// <summary>
		/// Cover
		/// </summary>
		public virtual string Cover
		{
			get;
			set;
		}

		/// <summary>
		/// Url
		/// </summary>
		public virtual string Url
		{
			get;
			set;
		}

		/// <summary>
		/// DisplayOrder
		/// </summary>
		public virtual int? DisplayOrder
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

		public Case()
		{
			CreationTime = DateTime.Now;
		}
	}
}
