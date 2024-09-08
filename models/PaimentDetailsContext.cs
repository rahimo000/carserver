using Microsoft.EntityFrameworkCore;

namespace carserver.models
{
    public class PaimentDetailsContext : DbContext
    {
        public PaimentDetailsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<PaimentDetails> PaimentDetails { get; set; }
    }
}
