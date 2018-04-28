using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// ArticleClass
	/// </summary>
	public class ArticleClass : Entity
	{
		/// <summary>
		/// ParentID
		/// </summary>
		public virtual int? ParentId
		{
			get;
			set;
		}

		/// <summary>
		/// Articles
		/// </summary>
		public virtual ICollection<Article> Articles
		{
			get;
			set;
		}

		/// <summary>
		/// ArticleType
		/// </summary>
		public virtual int ArticleType
		{
			get;
			set;
		}

		/// <summary>
		/// ClassName
		/// </summary>
		public virtual string ClassName
		{
			get;
			set;
		}

		/// <summary>
		/// FolderName
		/// </summary>
		public virtual string FolderName
		{
			get;
			set;
		}

		/// <summary>
		/// Description
		/// </summary>
		public virtual string Description
		{
			get;
			set;
		}

		/// <summary>
		/// Icon
		/// </summary>
		public virtual string Icon
		{
			get;
			set;
		}

		/// <summary>
		/// IsAsNavigation
		/// </summary>
		public virtual bool IsAsNavigation
		{
			get;
			set;
		}

		/// <summary>
		/// IsToNewWindow
		/// </summary>
		public virtual bool IsToNewWindow
		{
			get;
			set;
		}

		/// <summary>
		/// IsLink
		/// </summary>
		public virtual bool IsLink
		{
			get;
			set;
		}

		/// <summary>
		/// LinkUrl
		/// </summary>
		public virtual string LinkUrl
		{
			get;
			set;
		}

		/// <summary>
		/// Contents
		/// </summary>
		public virtual string Contents
		{
			get;
			set;
		}

		/// <summary>
		/// DisplayOrder
		/// </summary>
		public virtual int DisplayOrder
		{
			get;
			set;
		}

		/// <summary>
		/// IsEnabled
		/// </summary>
		public virtual bool IsEnabled
		{
			get;
			set;
		}

		/// <summary>
		/// IsAuditing
		/// </summary>
		public virtual bool IsAuditing
		{
			get;
			set;
		}

		public ArticleClass()
		{

		}
	}
}
