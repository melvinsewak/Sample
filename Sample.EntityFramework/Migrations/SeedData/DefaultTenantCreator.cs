using System.Linq;
using Sample.EntityFramework;
using Sample.MultiTenancy;

namespace Sample.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SampleDbContext _context;

        public DefaultTenantCreator(SampleDbContext context)
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
