using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SmartShop.Authorization.Roles;
using SmartShop.Authorization.Users;
using SmartShop.Entities;
using SmartShop.MultiTenancy;

namespace SmartShop.EntityFramework
{
    public class SmartShopDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
		//TODO: Define an IDbSet for your Entities...
		public virtual IDbSet<Area> Areas { get; set; }
		public virtual IDbSet<ArticleClass> ArticleClasses { get; set; }
		public virtual IDbSet<Article> Articles { get; set; }
		public virtual IDbSet<Case> Cases { get; set; }
		public virtual IDbSet<Group> Groups { get; set; }
		public virtual IDbSet<HelpCatalog> HelpCatalogs { get; set; }
		public virtual IDbSet<HelpDetail> HelpDetails { get; set; }
		public virtual IDbSet<Member> Members { get; set; }
		public virtual IDbSet<MicroAlbum> Micro_Albums { get; set; }
		public virtual IDbSet<MicroAlbumPhoto> MicroAlbumPhotos { get; set; }
		public virtual IDbSet<MicroCoupon> MicroCoupons { get; set; }
		public virtual IDbSet<MicroSite> MicroSites { get; set; }
		public virtual IDbSet<PhoneValid> PhoneValids { get; set; }
		public virtual IDbSet<QRcode> QRcodes { get; set; }
		public virtual IDbSet<ServiceReserve> ServiceReserves { get; set; }
		public virtual IDbSet<ShopCart> ShopCarts { get; set; }
		public virtual IDbSet<ShopOrder> ShopOrders { get; set; }
		public virtual IDbSet<ShopOrderItem> ShopOrderItemes { get; set; }
		public virtual IDbSet<ShopPayOrder> ShopPayOrders { get; set; }
		public virtual IDbSet<ShopProduct> ShopProducts { get; set; }
		public virtual IDbSet<ShopProductClass> ShopProductClasses { get; set; }

		/* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
		public SmartShopDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SmartShopDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SmartShopDbContext since ABP automatically handles it.
         */
        public SmartShopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SmartShopDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SmartShopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
