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
	public class CreateShopProductClassDto
	{
		public ShopProductClassDto ShopProductClass { get; set; }
	}
}
