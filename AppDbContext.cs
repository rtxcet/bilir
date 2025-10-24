using bilir.Models;
using Microsoft.EntityFrameworkCore;

namespace bilir
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slogan> Slogans { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}
