using test2.EntityFramework;
using EntityFramework.DynamicFilters;

namespace test2.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly test2DbContext _context;

        public InitialHostDbBuilder(test2DbContext context)
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
