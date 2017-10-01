using Basic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class BasicTest
    {
        public Car Car;
        public CarWasher CarWasher;

        [TestInitialize]
        public void Setup()
        {
            Car = new Car("Mercedes", "C200", "2017", 0, 0);
            CarWasher = new CarWasher();
        }

        [TestMethod]
        public void GetInfoTest()
        {
            Assert.AreEqual(Car.GetInfo(), "Car Info: 2017 Mercedes C200. Distance: 0 km. and traveling at 0 kmph.");
        }

        [TestMethod]
        public void GetInfoAfterTravellingTest()
        {
            Car.Accelerate(125);
            Car.Go(100);
            Car.Go(50);

            Assert.AreEqual("Car Info: 2017 Mercedes C200. Distance: 150 km. and traveling at 125 kmph.",
                Car.GetInfo());
        }

        [TestMethod]
        public void CarWasherTest()
        {
            Assert.AreEqual(CarWasher.WashCar(Car), "Washing the car: Mercedes C200 of 2017.");
        }
    }
}