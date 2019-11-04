using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Service
{
    /// <summary>
    /// IMotorVehicleService
    /// </summary>
    public interface IMotorVehicleService
    {
        /// <summary>
        /// Gets all motor vehicles.
        /// </summary>
        /// <returns></returns>
        IEnumerable<MotorVehicle> GetAllMotorVehicles();

        /// <summary>
        /// Adds the motor vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        void AddMotorVehicle(MotorVehicle vehicle);
    }
}
