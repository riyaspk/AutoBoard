using System;
using AutoBoard.Service;
using AutoBoard.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace AutoBoard.Test
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void VehicleServiceTest()
        {
            IMotorVehicleService service = new MotorVehicleService();
            var vehicles = service.GetAllMotorVehicles();
            if (vehicles != null)
            {
                Assert.IsInstanceOfType(vehicles, typeof(IEnumerable<MotorVehicle>));
            }
        }
    }
}
