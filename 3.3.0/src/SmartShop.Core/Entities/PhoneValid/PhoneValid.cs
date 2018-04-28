using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// PhoneValid
	/// </summary>
	public class PhoneValid : CreationAuditedEntity
	{
		/// <summary>
		/// Type
		/// </summary>
		public virtual ValidType Type
		{
			get;
			set;
		}

		/// <summary>
		/// Phone
		/// </summary>
		public virtual string Phone
		{
			get;
			set;
		}

		/// <summary>
		/// 验证码
		/// </summary>
		public virtual string Code
		{
			get;
			set;
		}

		/// <summary>
		/// 是否已经验证
		/// </summary>
		public virtual int? IsValid
		{
			get;
			set;
		}

		/// <summary>
		/// 验证时间
		/// </summary>
		public virtual DateTime? ValidTime
		{
			get;
			set;
		}

		public PhoneValid()
		{

		}
	}
}
