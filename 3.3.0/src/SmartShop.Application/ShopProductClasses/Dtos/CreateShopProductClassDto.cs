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
	[AutoMapTo(typeof(ShopProductClass))]
	public class CreateShopProductClassDto
	{
		/// <summary>
		/// ClassName
		/// </summary>
		[Required]
		public virtual string ClassName
		{
			get;
			set;
		}

		/// <summary>
		/// Description
		/// </summary>
		[Required]
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
