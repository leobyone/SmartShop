using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// HelpCatalog
	/// </summary>
	public class HelpCatalog : Entity
	{
		/// <summary>
		/// ParentID
		/// </summary>
		public virtual int? ParentId
		{
			get;
			set;
		}

		/// <summary>
		/// HelpDetails
		/// </summary>
		public virtual ICollection<HelpDetail> HelpDetails
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
		/// Description
		/// </summary>
		public virtual string Description
		{
			get;
			set;
		}

		/// <summary>
		/// Icon
		/// </summary>
		public virtual string Icon
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

		public HelpCatalog()
		{

		}
	}
}
