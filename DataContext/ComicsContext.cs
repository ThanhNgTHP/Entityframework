using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.DataContext
{
    public class ComicsContext : DbContext
    {
        public ComicsContext(DbContextOptions<ComicsContext> options) : base(options)
        {

        }

        public DbSet<Comics> comics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comics>().ToTable("Lop");
        }
    }
}
