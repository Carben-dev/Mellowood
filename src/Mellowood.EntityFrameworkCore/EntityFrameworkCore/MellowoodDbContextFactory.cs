using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Mellowood.Configuration;
using Mellowood.Web;

namespace Mellowood.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MellowoodDbContextFactory : IDesignTimeDbContextFactory<MellowoodDbContext>
    {
        public MellowoodDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MellowoodDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MellowoodDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MellowoodConsts.ConnectionStringName));

            return new MellowoodDbContext(builder.Options);
        }
    }
}
