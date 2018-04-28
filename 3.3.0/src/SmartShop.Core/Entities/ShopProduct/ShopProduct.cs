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
	/// Shop_Product
	/// </summary>
	public class ShopProduct : AuditedEntity<long>
	{
		/// <summary>
		/// CompanyId
		/// </summary>
		public virtual int CompanyId
		{
			get;
			set;
		}

		/// <summary>
		/// ProductNo
		/// </summary>
		public virtual string ProductNo
		{
			get;
			set;
		}

		/// <summary>
		/// CategoryID
		/// </summary>
		public virtual int CategoryId
		{
			get;
			set;
		}

		[ForeignKey("CategoryId")]
		public virtual ShopProductClass ShopProductClass
		{
			get;
			set;
		}

		/// <summary>
		/// Mode
		/// </summary>
		public virtual string Mode
		{
			get;
			set;
		}

		/// <summary>
		/// ProductType
		/// </summary>
		public virtual string ProductType
		{
			get;
			set;
		}

		/// <summary>
		/// Name
		/// </summary>
		public virtual string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Title
		/// </summary>
		public virtual string Title
		{
			get;
			set;
		}

		/// <summary>
		/// SubTitle
		/// </summary>
		public virtual string SubTitle
		{
			get;
			set;
		}

		/// <summary>
		/// Background
		/// </summary>
		public virtual string Background
		{
			get;
			set;
		}

		/// <summary>
		/// Cover
		/// </summary>
		public virtual string Cover
		{
			get;
			set;
		}

		/// <summary>
		/// ImageList
		/// </summary>
		public virtual string ImageList
		{
			get;
			set;
		}

		/// <summary>
		/// Templet
		/// </summary>
		public virtual string Templet
		{
			get;
			set;
		}

		/// <summary>
		/// CanCount
		/// </summary>
		public virtual int? CanCount
		{
			get;
			set;
		}

		/// <summary>
		/// ValidityDay
		/// </summary>
		public virtual int? ValidityDay
		{
			get;
			set;
		}

		/// <summary>
		/// Unit
		/// </summary>
		public virtual string Unit
		{
			get;
			set;
		}

		/// <summary>
		/// OrigPrice
		/// </summary>
		public virtual decimal OrigPrice
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
		/// Quantity
		/// </summary>
		public virtual int Quantity
		{
			get;
			set;
		}

		/// <summary>
		/// Sales
		/// </summary>
		public virtual int Sales
		{
			get;
			set;
		}

		/// <summary>
		/// IsRecommend
		/// </summary>
		public virtual int IsRecommend
		{
			get;
			set;
		}

		/// <summary>
		/// IsHot
		/// </summary>
		public virtual int IsHot
		{
			get;
			set;
		}

		/// <summary>
		/// IsTop
		/// </summary>
		public virtual int IsTop
		{
			get;
			set;
		}

		/// <summary>
		/// SortID
		/// </summary>
		public virtual int SortId
		{
			get;
			set;
		}

		/// <summary>
		/// Summary
		/// </summary>
		public virtual string Summary
		{
			get;
			set;
		} = string.Empty;

		/// <summary>
		/// Detail
		/// </summary>
		public virtual string Detail
		{
			get;
			set;
		} = string.Empty;

		/// <summary>
		/// IsRemove
		/// </summary>
		public virtual int IsRemove
		{
			get;
			set;
		}

		/// <summary>
		/// IsActivity
		/// </summary>
		public virtual int IsActivity
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

		/// <summary>
		/// StatusMessage
		/// </summary>
		public virtual string StatusMessage
		{
			get;
			set;
		}

		public ShopProduct()
		{

		}
	}
}
