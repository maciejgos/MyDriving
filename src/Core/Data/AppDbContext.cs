using Microsoft.EntityFrameworkCore;

namespace MyDriving.Core.Data
{
    //TODO: Remove singleton due to issue with param less AppDbContext constructor
    class AppDbContext : DbContext
    {
        private static AppDbContext instance;

        public static AppDbContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppDbContext();

                return instance;
            }
        }

        public DbSet<Models.Vehicle> Vehicles { get; set; }

        public DbSet<Models.Refuel> Fuellings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDriving.db");
        }

        public AppDbContext() { }
    }
}
