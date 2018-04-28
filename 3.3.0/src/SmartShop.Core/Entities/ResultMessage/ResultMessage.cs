using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	public class ResultMessage
	{
		public virtual int Code { get; set; } = 0;
		public virtual string Message { get; set; } = string.Empty;
	}
}
