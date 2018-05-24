using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses.Dtos
{
	/// <summary>
	/// UpdateShopProductClassInput
	/// </summary>
	public class UpdateShopProductClassInput: Entity<int>
	{
		/// <summary>
		/// ClassName
		/// </summary>
		[Required]
		[MaxLength(SmartShopConsts.MaxNameLength)]
		public virtual string ClassName
		{
			get;
			set;
		}

		/// <summary>
		/// Description
		/// </summary>
		[Required]
		[MaxLength(SmartShopConsts.MaxTextLength)]
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
	}
}
