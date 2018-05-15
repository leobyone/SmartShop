using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Area
	/// </summary>
	public class Area : Entity
	{
		/// <summary>
		/// ParentId
		/// </summary>
		public virtual int? ParentId { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[Required]
		public virtual string Name { get; set; }

		/// <summary>
		/// SortId
		/// </summary>
		public virtual int? SortId { get; set; }

		/// <summary>
		/// IsUsed
		/// </summary>
		public virtual int? IsUsed { get; set; }

		public Area()
		{
			this.ParentId = 0;
			this.SortId = 0;
			this.IsUsed = 0;
		}
	}
}
