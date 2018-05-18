using Abp.Runtime.Validation;
using SmartShop.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.ShopProductClasses.Dtos
{
	/// <summary>
	/// GetShopProductClassesInput
	/// </summary>
	public class GetShopProductClassesInput : PagedSortedAndFilteredInputDto, IShouldNormalize
	{
		/// <summary>
		/// 正常化
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
