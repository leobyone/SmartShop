using Abp.AutoMapper;
using SmartShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses.Dtos
{
	/// <summary>
	/// CreateShopProductClassInput
	/// </summary>
	[AutoMapTo(typeof(ShopProductClass))]
	public class CreateShopProductClassInput
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
