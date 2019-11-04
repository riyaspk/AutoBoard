using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoBoard.DAL;

namespace AutoBoard.Service
{
    /// <summary>
    /// I
    /// Service class for MotorVehicleService
    /// </summary>
    public class MotorVehicleService : IMotorVehicleService
    {
        /// <summary>
        /// Gets or sets the repository.
        /// </summary>
        /// <value>
        /// The repository.
        /// </value>
        public IMotorVehicleRepository Repository { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MotorVehicleService"/> class.
        /// </summary>
        public MotorVehicleService()
        {
            Repository = new MotorVehicleRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MotorVehicleService"/> class.
        /// #### Constructor for dipendency injection
        /// </summary>
        /// <param name="repository">The repository.</param>
        public MotorVehicleService(IMotorVehicleRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Gets all motor vehicles.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MotorVehicle> GetAllMotorVehicles()
        {
            return Repository.GetAll();
        }

        /// <summary>
        /// Adds the motor vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public void AddMotorVehicle(MotorVehicle vehicle)
        {
            try
            {
                MotorVehicleRepository repository = new MotorVehicleRepository();
                repository.Insert(vehicle);
            }
            catch (Exception ex)
            {
                throw new AutoBoardServiceException("Unexpected operation, please verify the inputs!", ex);
            }
        }
    }
}
