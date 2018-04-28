using System.Linq;
using SmartShop.EntityFramework;
using SmartShop.MultiTenancy;

namespace SmartShop.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SmartShopDbContext _context;

        public DefaultTenantCreator(SmartShopDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
