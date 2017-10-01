using Interfaces.Car;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class InterfaceCarTest
    {
        public Car Car;

        [TestInitialize]
        public void Setup()
        {
            Car = new Car("Mercedes", "C200", "2017", 0, 0);
        }

        [TestMethod]
        public void IsVehicle()
        {
            // ReSharper disable once IsExpressionAlwaysTrue
            Assert.IsTrue(Car is IVehicle);
        }

        [TestMethod]
        public void GetInfoTest()
        {
            Assert.AreEqual(Car.GetInfo(), "Car Info: 2017 Mercedes C200. Distance: 0 km. and traveling at 0 kmph.");
        }

        [TestMethod]
        public void StopTest()
        {
            Car.Stop();

            Assert.AreEqual(0, Car.Speed);
        }


        [TestMethod]
        public void InfoAfterTravelling()
        {
            Car.Accelerate(125);
            Car.Go(100);
            Car.Go(50);

            Assert.AreEqual("Car Info: 2017 Mercedes C200. Distance: 150 km. and traveling at 125 kmph.",
                Car.GetInfo());
        }
    }
}