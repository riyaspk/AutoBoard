using System;
using AutoBoard.DAL;
using AutoBoard.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AutoBoard.Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Vehicles the repository test.
        /// </summary>
        [TestMethod]
        public void VehicleRepositoryTest()
        {
            IMotorVehicleRepository repository = new MotorVehicleRepository();
            var vehicles = repository.GetAll();
            if (vehicles != null)
            {
                Assert.IsInstanceOfType(vehicles, typeof(IEnumerable<MotorVehicle>));
            }
        }
    }
}
