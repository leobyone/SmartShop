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
	/// Micro_Album
	/// </summary>
	public class MicroAlbum : AuditedEntity
	{
		/// <summary>
		/// SiteId
		/// </summary>
		public virtual int? SiteId
		{
			get;
			set;
		}

		/// <summary>
		/// MicroSite
		/// </summary>
		[ForeignKey("SiteId")]
		public virtual MicroSite MicroSite
		{
			get;
			set;
		}

		/// <summary>
		/// MicroAlbumPhotos
		/// </summary>
		public virtual ICollection<MicroAlbumPhoto> MicroAlbumPhotos
		{
			get;
			set;
		}

		/// <summary>
		/// Type
		/// </summary>
		public virtual int? Type
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

		public MicroAlbum()
		{

		}
	}
}
