using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// Shop_Carts
	/// </summary>
	public class ShopCart : CreationAuditedEntity<long>
	{
		/// <summary>
		/// ShopId
		/// </summary>
		public virtual int ShopId
		{
			get;
			set;
		}

		/// <summary>
		/// ProductId
		/// </summary>
		public virtual int ProductId
		{
			get;
			set;
		}

		/// <summary>
		/// ProductName
		/// </summary>
		public virtual string ProductName
		{
			get;
			set;
		} = string.Empty;

		/// <summary>
		/// ProductPic
		/// </summary>
		public virtual string ProductPic
		{
			get;
			set;
		} = string.Empty;

		/// <summary>
		/// MemberId
		/// </summary>
		public virtual int MemberId
		{
			get;
			set;
		}

		[ForeignKey("MemberId")]
		public virtual Member Member
		{
			get;
			set;
		}

		/// <summary>
		/// CookieTag
		/// </summary>
		public virtual string CookieTag
		{
			get;
			set;
		} = string.Empty;

		/// <summary>
		/// TotPrice
		/// </summary>
		public virtual decimal TotPrice
		{
			get;
			set;
		}

		/// <summary>
		/// Price
		/// </summary>
		public virtual decimal Price
		{
			get;
			set;
		}

		/// <summary>
		/// ProductNum
		/// </summary>
		public virtual int ProductNum
		{
			get;
			set;
		}
	
		/// <summary>
		/// Status
		/// </summary>
		public virtual int Status
		{
			get;
			set;
		}

		public ShopCart()
		{

		}
	}
}
