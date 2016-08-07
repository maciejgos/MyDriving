using MyDriving.Core.Models;
using MyDriving.Core.Repositories;
using MyDriving.Core.Repositories.Design;
using System.Collections.Generic;
using Xunit;

namespace MyDriving.Core.Tests
{
    public class VehicleRepositoryTests
    {
        [Fact]
        public void Can_Get_Vehicle_By_Id()
        {
            //Arrange
            Vehicle expectedVehicle = new Vehicle { Id = 1, Make = "Toyota", Model = "Prius", YearOfManufacture = 2014, Odometer = 45000 };
            IVehicleRepository repository = new FakeVehicleRepository();

            //Act
            Vehicle actualVehicle = repository.GetById(1);

            //Assert
            Assert.Equal(expectedVehicle, actualVehicle, new VehicleComparer());
        }
    }

    internal class VehicleComparer : IEqualityComparer<Vehicle>
    {
        public bool Equals(Vehicle x, Vehicle y)
        {
            return x.Make == y.Make && x.Model == y.Model && x.YearOfManufacture == y.YearOfManufacture && x.Odometer == y.Odometer;
        }

        public int GetHashCode(Vehicle obj)
        {
            return obj.GetHashCode();
        }
    }
}
