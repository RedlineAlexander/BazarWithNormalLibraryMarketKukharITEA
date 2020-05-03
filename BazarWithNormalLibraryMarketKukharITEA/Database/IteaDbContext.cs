using BazarWithNormalLibraryMarketKukharITEA.Entities;
using Microsoft.EntityFrameworkCore;

namespace database.BazarWithNormalLibraryMarketKukharITEA
{
    public class IteaDbContext : DbContext
    {
        public DbSet<Buyers> Buyers { get; set; }

        public DbSet<Consumers> Consumers { get; set; }

        public IteaDbContext(DbContextOptions<IteaDbContext> options ): base(options)
        {

        }
    }
}