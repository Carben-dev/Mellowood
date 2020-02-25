using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mellowood.Authorization.Roles;
using Mellowood.Authorization.Users;
using Mellowood.MultiTenancy;
using Mellowood.ContentManageSystem;

namespace Mellowood.EntityFrameworkCore
{
    public class MellowoodDbContext : AbpZeroDbContext<Tenant, Role, User, MellowoodDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        // Adding Content to DbContext
        public DbSet<Content> Contents { get; set; }

        public MellowoodDbContext(DbContextOptions<MellowoodDbContext> options)
            : base(options)
        {
        }
    }
}
