using grupoAtlas.Model;
using Microsoft.EntityFrameworkCore;

namespace grupoAtlas.Persistence
{
    public class ContextoOracle : DbContext
    {
        public DbSet<Moeda> Moeda { get; set; }

        public ContextoOracle(DbContextOptions<ContextoOracle> options) : base(options) { }
    }
}
