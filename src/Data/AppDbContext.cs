using Microsoft.EntityFrameworkCore;

namespace MyDriving.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Model.Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDriving.db");
        }
    }
}
