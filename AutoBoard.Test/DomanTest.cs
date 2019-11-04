using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoBoard.Domain;

namespace AutoBoard.Test
{
    [TestClass]
    public class DomanTest
    {
        [TestMethod]
        public void BicycleDomainTest()
        {
            Bicycle bicycle = new Bicycle() { BicycleModel = new BicycleModel() { Name = "Test Model", Weight = 20 } };
            Assert.AreEqual(bicycle.BicycleModel.Age, 20);
        }
    }
}
