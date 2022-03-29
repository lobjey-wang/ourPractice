using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class HelloWorldDbContext : DbContext
    {
        public HelloWorldDbContext()
        {
        }

        public HelloWorldDbContext(DbContextOptions<HelloWorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }
    }
}
