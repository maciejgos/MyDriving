using Microsoft.Practices.ServiceLocation;
using MyDriving.Core.Calculators;
using System.Collections.Generic;
using System.Linq;

namespace MyDriving.Models
{
    public class Vehicle
    {
        private readonly ICalculation<IEnumerable<Refuel>, decimal> _fuelConsumptionCalc;

        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int ProductionYear { get; set; }

        public int Mileage { get; set; }

        public virtual ICollection<Refuel> Fuellings { get; set; }

        public decimal AverageFuelConsumption
        {
            get
            {
                if (Fuellings.Count() > 0)
                    return _fuelConsumptionCalc.Calculate(Fuellings);
                else
                    return 0.00m;
            }
        }

        public Vehicle()
        {
            _fuelConsumptionCalc = ServiceLocator.Current.GetInstance<ICalculation<IEnumerable<Refuel>, decimal>>();
            Fuellings = Enumerable.Empty<Refuel>().ToList();
        }
    }
}
