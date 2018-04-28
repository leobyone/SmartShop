using System.Data.Common;
using Abp.Zero.EntityFramework;
using SmartShop.Authorization.Roles;
using SmartShop.Authorization.Users;
using SmartShop.MultiTenancy;

namespace SmartShop.EntityFramework
{
    public class SmartShopDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

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
