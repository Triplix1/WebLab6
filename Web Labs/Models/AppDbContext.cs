using Microsoft.EntityFrameworkCore;

namespace Web_Labs.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<AccordoinModel> Models { get; set; }
    }
}
