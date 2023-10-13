using Microsoft.EntityFrameworkCore;

namespace web_api.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Member> Members { get; set; }
    }
}
