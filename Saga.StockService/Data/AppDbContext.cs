using Microsoft.EntityFrameworkCore;

namespace Saga.StockService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<StockRecord> StockRecords { get; set; }

    }
}
