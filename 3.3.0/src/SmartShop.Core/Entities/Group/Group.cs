using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Group
	/// </summary>
	public class Group : Entity
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
		/// CompanyID
		/// </summary>
		public virtual int? CompanyId
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
		/// Ico
		/// </summary>
		public virtual string Ico
		{
			get;
			set;
		}

		/// <summary>
		/// IsEnabled
		/// </summary>
		public virtual bool IsEnabled
		{
			get;
			set;
		}

		/// <summary>
		/// IsChecked
		/// </summary>
		public virtual bool IsChecked
		{
			get;
			set;
		}

		public Group()
		{

		}
	}
}
