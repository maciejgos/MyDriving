using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyDriving.Core.Data;

namespace MyDriving.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160627161647_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("MyDriving.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<int>("Mileage");

                    b.Property<string>("Model");

                    b.Property<int>("ProductionYear");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
        }
    }
}
