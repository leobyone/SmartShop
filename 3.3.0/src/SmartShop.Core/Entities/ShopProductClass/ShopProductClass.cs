using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Shop_ProductClass
	/// </summary>
	public class ShopProductClass : Entity
	{
		/// <summary>
		/// CompanyID
		/// </summary>
		public virtual int? CompanyId
		{
			get;
			set;
		}

		/// <summary>
		/// ParentID
		/// </summary>
		public virtual int? ParentId
		{
			get;
			set;
		}

		/// <summary>
		/// ClassName
		/// </summary>
		public virtual string ClassName
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
		/// DisplayOrder
		/// </summary>
		public virtual int? DisplayOrder
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

		public ShopProductClass()
		{

		}
	}
}
