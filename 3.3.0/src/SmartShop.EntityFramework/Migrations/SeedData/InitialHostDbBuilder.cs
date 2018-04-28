using SmartShop.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SmartShop.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SmartShopDbContext _context;

        public InitialHostDbBuilder(SmartShopDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
