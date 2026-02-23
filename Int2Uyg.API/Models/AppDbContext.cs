using Microsoft.EntityFrameworkCore;

namespace Int2Uyg.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Survey> Surveys { get; set; }
    }
}