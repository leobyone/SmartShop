﻿using Abp.Runtime.Validation;
using SmartShop.Dto;
using SmartShop.Entities;

namespace SmartShop.ShopProducts.Dtos
{
	public class GetShopProductsInput : PagedAndSortedInputDto, IShouldNormalize
	{
		////BCC/ BEGIN CUSTOM CODE SECTION
		////ECC/ END CUSTOM CODE SECTION
		/// <summary>
		/// 模糊搜索使用的关键字
		/// </summary>
		public string Filter { get; set; }

		/// <summary>
		/// 正常化排序使用
		/// </summary>
		public void Normalize()
		{
			if (string.IsNullOrEmpty(Sorting))
			{
				Sorting = "Id";
			}
		}

	}
}