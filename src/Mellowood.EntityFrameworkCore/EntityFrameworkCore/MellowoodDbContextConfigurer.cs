using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mellowood.EntityFrameworkCore
{
    public static class MellowoodDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MellowoodDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MellowoodDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
