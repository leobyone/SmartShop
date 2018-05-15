using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Dto
{
	public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
	{
		public string Filter { get; set; }
	}
}
