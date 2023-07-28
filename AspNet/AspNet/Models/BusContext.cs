using AspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet.Models
{
    public partial class BusContext : DbContext
    {
        public BusContext() { }

        public BusContext(DbContextOptions<BusContext> options)
            : base(options)
        {
        }

        public DbSet<AspNet.Models.BusTable>? BusTable { get; set; }
    }
}
