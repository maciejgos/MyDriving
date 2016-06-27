using Microsoft.EntityFrameworkCore;

namespace MyDriving.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Models.Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDriving.db");
        }
    }
}
