using Interfaces.Cutter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class InterfaceCutterTest
    {
        [TestMethod]
        public void IsActorActing()
        {
            var actor = CutterFactory.CreateCutter("actor");
            Assert.AreEqual(actor.Cut(), "I've just stopped acting!");
        }

        [TestMethod]
        public void IsBarberCuttingStylish()
        {
            var barber = CutterFactory.CreateCutter("barber");
            Assert.AreEqual(barber.Cut(), "I'm gonna cut your hair very stylish!");
        }

        [TestMethod]
        public void IsButcherCuttingMeat()
        {
            var butcher = CutterFactory.CreateCutter("butcher");
            Assert.AreEqual(butcher.Cut(), "I've just started cutting the meat!");
        }
    }
}