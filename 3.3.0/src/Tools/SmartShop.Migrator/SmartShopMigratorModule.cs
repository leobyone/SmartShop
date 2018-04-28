using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SmartShop.EntityFramework;

namespace SmartShop.Migrator
{
    [DependsOn(typeof(SmartShopDataModule))]
    public class SmartShopMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SmartShopDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}