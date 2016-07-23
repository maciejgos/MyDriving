using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void ShouldBlockCalculationWhenThereIsNotEnougthRefuel()
        {

        }
    }
}
