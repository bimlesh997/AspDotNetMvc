using System.Linq;
using test2.EntityFramework;
using test2.MultiTenancy;

namespace test2.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly test2DbContext _context;

        public DefaultTenantCreator(test2DbContext context)
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
