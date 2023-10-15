using Microsoft.EntityFrameworkCore;

namespace CarRentalWebService.Data
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext (DbContextOptions<ConnectionContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Client> Client { get; set; } = default!;
        public DbSet<Models.Admin> Admin { get; set; } = default!;
    }
}
