using Microsoft.EntityFrameworkCore;

namespace Saga.PaymentService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Payment> Payments { get; set; }

    }
}
