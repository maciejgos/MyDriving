using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyDriving.Core.Data;

namespace MyDriving.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20160730141428_IsDefaultVehicle")]
    partial class IsDefaultVehicle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("MyDriving.Models.Refuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Liters");

                    b.Property<int>("Mileage");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PricePerLiter");

                    b.Property<int?>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Fuellings");
                });

            modelBuilder.Entity("MyDriving.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Make");

                    b.Property<int>("Mileage");

                    b.Property<string>("Model");

                    b.Property<int>("ProductionYear");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("MyDriving.Models.Refuel", b =>
                {
                    b.HasOne("MyDriving.Models.Vehicle", "Vehicle")
                        .WithMany("Fuellings")
                        .HasForeignKey("VehicleId");
                });
        }
    }
}
