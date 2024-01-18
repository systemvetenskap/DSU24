using Microsoft.EntityFrameworkCore;

namespace DSU24.Models.Data
{
    public class SportDbContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Season> Seasons { get; set; }

        public SportDbContext(DbContextOptions<SportDbContext> options) : base(options) { }

    }
}
