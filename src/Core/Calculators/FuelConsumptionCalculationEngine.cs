using System;
using System.Collections.Generic;
using MyDriving.Models;
using System.Linq;

namespace MyDriving.Core.Calculators
{
    public class FuelConsumptionCalculationEngine : ICalculation<IEnumerable<Refuel>, decimal>
    {
        public decimal Calculate(IEnumerable<Refuel> entity)
        {
            if (entity.Count() < 2)
                throw new ArgumentException("Not enough refuell");

            decimal result = 0.0m;
            var orderedCollection = entity.OrderByDescending(item => item.Id);
            var arr = orderedCollection.Take(2).ToArray();

            int distance = arr[0].Mileage - arr[1].Mileage;
            result = (Convert.ToDecimal(arr[0].Liters) / Convert.ToDecimal(distance)) * 100;

            return Math.Round(result, 1);
        }
    }
}
