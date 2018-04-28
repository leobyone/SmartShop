using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Member
	/// </summary>
	public class Member : AuditedEntity
	{
		/// <summary>
		/// CompanyID
		/// </summary>
		public virtual int? CompanyId
		{
			get;
			set;
		}

		/// <summary>
		/// GroupID
		/// </summary>
		public virtual int? GroupId
		{
			get;
			set;
		}

		/// <summary>
		/// UserName
		/// </summary>
		public virtual string UserName
		{
			get;
			set;
		}

		/// <summary>
		/// LoginPassword
		/// </summary>
		public virtual string LoginPassword
		{
			get;
			set;
		}

		/// <summary>
		/// Email
		/// </summary>
		public virtual string Email
		{
			get;
			set;
		}

		/// <summary>
		/// IsEmailVerified
		/// </summary>
		public virtual bool IsEmailVerified
		{
			get;
			set;
		}

		/// <summary>
		/// Mobile
		/// </summary>
		public virtual string Mobile
		{
			get;
			set;
		}

		/// <summary>
		/// IsMobileVerified
		/// </summary>
		public virtual bool IsMobileVerified
		{
			get;
			set;
		}

		/// <summary>
		/// RealName
		/// </summary>
		public virtual string RealName
		{
			get;
			set;
		}

		/// <summary>
		/// NickName
		/// </summary>
		public virtual string NickName
		{
			get;
			set;
		}

		/// <summary>
		/// IsActivated
		/// </summary>
		public virtual bool IsActivated
		{
			get;
			set;
		}

		/// <summary>
		/// Gender
		/// </summary>
		public virtual string Gender
		{
			get;
			set;
		}

		/// <summary>
		/// Avatar
		/// </summary>
		public virtual string Avatar
		{
			get;
			set;
		}

		/// <summary>
		/// Job
		/// </summary>
		public virtual string Job
		{
			get;
			set;
		}

		/// <summary>
		/// Tel
		/// </summary>
		public virtual string Tel
		{
			get;
			set;
		}

		/// <summary>
		/// ProvinceID
		/// </summary>
		public virtual int? ProvinceId
		{
			get;
			set;
		}

		/// <summary>
		/// Province
		/// </summary>
		public virtual string Province
		{
			get;
			set;
		}

		/// <summary>
		/// CityID
		/// </summary>
		public virtual int? CityId
		{
			get;
			set;
		}

		/// <summary>
		/// City
		/// </summary>
		public virtual string City
		{
			get;
			set;
		}

		/// <summary>
		/// AreaID
		/// </summary>
		public virtual int? AreaId
		{
			get;
			set;
		}

		/// <summary>
		/// Area
		/// </summary>
		public virtual string Area
		{
			get;
			set;
		}

		/// <summary>
		/// Address
		/// </summary>
		public virtual string Address
		{
			get;
			set;
		}

		/// <summary>
		/// Birthday
		/// </summary>
		public virtual string Birthday
		{
			get;
			set;
		}

		/// <summary>
		/// LunarBirthday
		/// </summary>
		public virtual string LunarBirthday
		{
			get;
			set;
		}

		/// <summary>
		/// CreateIP
		/// </summary>
		public virtual string CreateIP
		{
			get;
			set;
		}

		/// <summary>
		/// OpenId
		/// </summary>
		public virtual string OpenId
		{
			get;
			set;
		}

		/// <summary>
		/// UnionId
		/// </summary>
		public virtual string UnionId
		{
			get;
			set;
		}

		/// <summary>
		/// Status
		/// </summary>
		public virtual int? Status
		{
			get;
			set;
		}

		public Member()
		{

		}
	}
}
