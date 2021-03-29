using Microsoft.EntityFrameworkCore;

namespace ServerApi.Models
{
    public class DataContext: DbContext
    {      
        public DbSet<NegocioControl> NegocioControl { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NegocioControl>().ToTable("NegocioControl");
        }
    }
}