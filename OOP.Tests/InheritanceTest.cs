using Inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class InheritanceTest
    {
        public Car Car;
        public Car F1Car;
        
        [TestInitialize]
        public void Setup()
        {
            Car = new Car
            {
                Make = "Sample",
                Model = "Model",
                Speed = 100,
                Year = "2017"
            };
            
            F1Car = new F1Car
            {
                Make = "Mercedes",
                Model = "C200",
                Year = "2017",
                Distance = 20000,
                Speed = 310,
                Pilot = "Mehmet"
            };
        }

        [TestMethod]
        public void GetInfoTest()
        {
            Assert.AreEqual(
                "Car Info: 2017 Mercedes C200. Distance: 20000 km. and traveling at 310 kmph. Pilot is Mehmet.",
                F1Car.GetInfo());
        }

        [TestMethod]
        public void GoTest()
        {
            var initialDistance = F1Car.Distance;
            const int distanceToGo = 10;
            F1Car.Go(distanceToGo);
            var difference = F1Car.Distance - initialDistance;

            Assert.AreEqual(distanceToGo, difference);
        }

        [TestMethod]
        public void F1CarAccelerateTest()
        {
            F1Car.Accelerate(350);

            Assert.AreEqual(350, F1Car.Speed);
        }

        [TestMethod]
        public void StopTest()
        {
            F1Car.Stop();

            Assert.AreEqual(0, F1Car.Speed);
        }

        [TestMethod]
        public void CarAccelerateTest()
        {
            Car.Accelerate(150);

            Assert.AreEqual(150, Car.Speed);
        }
    }
}