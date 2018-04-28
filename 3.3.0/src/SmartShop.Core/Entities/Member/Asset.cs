using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	public class Assets: Entity
	{
		/// <summary>
		/// 商家id
		/// </summary>
		public int MemberId { get; set; }
		/// <summary>
		/// 电话
		/// </summary>
		public string MemberPhone { get; set; }
		/// <summary>
		/// Cookie标识
		/// </summary>
		public string CookieTag { get; set; } = string.Empty;
	}
}
