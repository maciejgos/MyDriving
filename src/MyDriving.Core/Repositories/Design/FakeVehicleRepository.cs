using System;
using MyDriving.Core.Models;

namespace MyDriving.Core.Repositories.Design
{
    public class FakeVehicleRepository : IVehicleRepository
    {
        public Vehicle GetById(int v)
        {
            return new Vehicle { Id = 1, Make = "Toyota", Model = "Prius", YearOfManufacture = 2014, Odometer = 45000 };
        }
    }
}