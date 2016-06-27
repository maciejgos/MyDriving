﻿using Microsoft.EntityFrameworkCore;

namespace MyDriving.Data
{
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDriving.db");
        }

        private AppDbContext() { }
    }
}
