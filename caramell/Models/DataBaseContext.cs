using Microsoft.EntityFrameworkCore;

namespace caramell.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
