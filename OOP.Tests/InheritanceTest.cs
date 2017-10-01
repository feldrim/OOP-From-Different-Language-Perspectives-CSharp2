using Inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void Info()
        {
            var f1Car1 = new F1Car
            {
                Make = "Mercedes",
                Model = "C200",
                Year = "2017",
                Distance = 20000,
                Speed = 310,
                Pilot = "Mehmet"
            };

            Assert.AreEqual(
                "Car Info: 2017 Mercedes C200. Distance: 20000 km. and traveling at 310 kmph. Pilot is Mehmet.",
                f1Car1.GetInfo());
        }
    }
}