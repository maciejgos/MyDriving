using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;

namespace MyDriving.UnitTest.Core
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void CanCalculateAverageFuelConsumption()
        {
            IEnumerable<Models.Fuelling> collection = new List<Models.Fuelling>
            {
                new Models.Fuelling
                {
                    Id = 1,
                    Liters = 40,
                    Mileage = 180000
                },
                new Models.Fuelling
                {
                    Id = 2,
                    Liters = 40,
                    Mileage = 180420
                },
                new Models.Fuelling
                {
                    Id = 3,
                    Liters = 40,
                    Mileage = 180840
                }

            };
            var average = MyDriving.Core.CalculationEngine.Calculate(collection);

            Assert.AreEqual(9.5m, average);
        }

        [TestMethod]
        public void ShouldBlockCalculationWhenThereIsNotEnougthRefuel()
        {
            IEnumerable<Models.Fuelling> collection = System.Linq.Enumerable.Empty<Models.Fuelling>();
            MyDriving.Core.CalculationEngine.Calculate(collection);

            Assert.ThrowsException<ArgumentException>(() => "Just a test");
        }
    }
}
