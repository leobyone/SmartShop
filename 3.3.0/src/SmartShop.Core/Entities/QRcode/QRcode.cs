using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// QRcode
	/// </summary>
	public class QRcode : Entity
	{
		/// <summary>
		/// Type
		/// </summary>
		public virtual string Type
		{
			get;
			set;
		}

		/// <summary>
		/// SceneId
		/// </summary>
		public virtual int? SceneId
		{
			get;
			set;
		}

		/// <summary>
		/// SceneStr
		/// </summary>
		public virtual string SceneStr
		{
			get;
			set;
		}

		/// <summary>
		/// Ticket
		/// </summary>
		public virtual string Ticket
		{
			get;
			set;
		}

		/// <summary>
		/// ExpireTime
		/// </summary>
		public virtual DateTime? ExpireTime
		{
			get;
			set;
		}

		/// <summary>
		/// Url
		/// </summary>
		public virtual string Url
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
		/// UseStatus
		/// </summary>
		public virtual int? UseStatus
		{
			get;
			set;
		}

		/// <summary>
		/// LastUseTime
		/// </summary>
		public virtual DateTime? LastUseTime
		{
			get;
			set;
		}

		public QRcode()
		{

		}
	}
}
