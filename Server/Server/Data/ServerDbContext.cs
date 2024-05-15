using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
