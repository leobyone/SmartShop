using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses.Dtos
{
	[AutoMapFrom(typeof(ShopProductClass))]
	public class ShopProductClassDto : EntityDto
	{
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
	}
}
