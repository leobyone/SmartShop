using Abp.Domain.Entities;
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
	/// Micro_AlbumPhoto
	/// </summary>
	public class MicroAlbumPhoto : CreationAuditedEntity, ISoftDelete
	{
		/// <summary>
		/// AlbumId
		/// </summary>
		public virtual int? AlbumId
		{
			get;
			set;
		}

		/// <summary>
		/// MicroAlbum
		/// </summary>
		[ForeignKey("AlbumId")]
		public virtual MicroAlbum MicroAlbum
		{
			get;
			set;
		}

		/// <summary>
		/// PhotoPath
		/// </summary>
		public virtual string PhotoPath
		{
			get;
			set;
		}

		/// <summary>
		/// Remark
		/// </summary>
		public virtual string Remark
		{
			get;
			set;
		}

		/// <summary>
		/// IsUse
		/// </summary>
		public virtual int? IsUse
		{
			get;
			set;
		}

		public virtual bool IsDeleted
		{
			get;
			set;
		}

		public MicroAlbumPhoto()
		{

		}
	}
}
