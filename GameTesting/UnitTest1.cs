using System;
using MyCarRace.CarRaceModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactory()
        {
            Punter punter = Factory.GetPunter("Vicky");
            bool result = punter is Vicky;
            Assert.AreEqual(result, true);
        }
    }
}
