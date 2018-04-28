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
	/// HelpDetail
	/// </summary>
	public class HelpDetail : AuditedEntity<long>
	{
		/// <summary>
		/// CatalogId
		/// </summary>
		public virtual int? CatalogId
		{
			get;
			set;
		}

		[ForeignKey("CatalogId")]
		public virtual HelpCatalog HelpCatalog
		{
			get;
			set;
		}

		/// <summary>
		/// Type
		/// </summary>
		public virtual int? Type
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
		/// Summary
		/// </summary>
		public virtual string Summary
		{
			get;
			set;
		}

		/// <summary>
		/// Answer
		/// </summary>
		public virtual string Answer
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

		public HelpDetail()
		{

		}
	}
}
