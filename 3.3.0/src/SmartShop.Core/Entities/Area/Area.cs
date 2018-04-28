using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
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
		public virtual int? ParentId { get; set; }

		public virtual string Name { get; set; }

		public virtual int? SortId { get; set; }

		public virtual int? IsUsed { get; set; }

		public Area() { }
	}
}
