using System.Collections.Generic;

namespace MyDriving.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public int Mileage { get; set; }

        public IEnumerable<Refuel> Refuels { get; set; }
    }
}
