using System;
using System.Collections.Generic;
using MyDriving.Models;
using System.Linq;

namespace MyDriving.Core
{
    public class CalculationEngine
    {
        public static decimal Calculate(IEnumerable<Fuelling> collection)
        {
            decimal result = 0.0m;
            var orderedCollection = collection.OrderByDescending(item => item.Id);
            var arr = orderedCollection.Take(2).ToArray();

            int distance = arr[0].Mileage - arr[1].Mileage;
            result = (Convert.ToDecimal(arr[0].Liters) / Convert.ToDecimal(distance)) * 100;

            return Math.Round(result,1);
        }
    }
}
