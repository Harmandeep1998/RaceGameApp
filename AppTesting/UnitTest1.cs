using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceGameApp;
using System;

namespace AppTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFactoryTest()
        {
            Punter punter = PunterFactory.GetPunter(11);
            Assert.AreEqual(punter == null, true);
        }
    }
}
