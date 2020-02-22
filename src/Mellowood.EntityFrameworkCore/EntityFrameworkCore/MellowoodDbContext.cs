using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mellowood.Authorization.Roles;
using Mellowood.Authorization.Users;
using Mellowood.MultiTenancy;

namespace Mellowood.EntityFrameworkCore
{
    public class MellowoodDbContext : AbpZeroDbContext<Tenant, Role, User, MellowoodDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MellowoodDbContext(DbContextOptions<MellowoodDbContext> options)
            : base(options)
        {
        }
    }
}
