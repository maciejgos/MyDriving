using System.Collections.Generic;
using System.Linq;

namespace MyDriving.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int ProductionYear { get; set; }

        public int Mileage { get; set; }

        public virtual ICollection<Fuelling> Fuellings { get; set; }

        public Vehicle()
        {
            Fuellings = Enumerable.Empty<Fuelling>().ToList();
        }
    }
}
