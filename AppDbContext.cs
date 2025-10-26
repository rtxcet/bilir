using bilir.Models;
using Microsoft.EntityFrameworkCore;

namespace bilir
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slogan> Slogans { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
