using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for MotorVehicle 
    /// </summary>
    public class MotorVehicle : Vehicle
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        /// <example>Car, Bus, etc</example>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the motor vehicle model.
        /// </summary>
        /// <value>
        /// The motor vehicle model.
        /// </value>
        public MotorVehicleModel MotorVehicleModel { get; set; }

        /// <summary>
        /// Gets or sets the size of the engine.
        /// </summary>
        /// <value>
        /// The size of the engine.
        /// </value>
        public int EngineSize { get; set; }

        #region  Methods

        /// <summary>
        /// Print output
        /// </summary>
        /// <returns></returns>
        public override string Print()
        {
            return string.Format("RegistrationID={0}, Make={1}, Model={2}, MaxPassengers={3}, NoOfWheeels={4}, Milage={5}",
                RegistrationID.ToString().PadLeft(8,'0'), 
                Make != null ? Make.Name.ToString().PadLeft(8, ' ') : string.Empty.ToString().PadLeft(8, ' '), 
                MotorVehicleModel != null ? MotorVehicleModel.Name.ToString().PadLeft(8, ' ') : string.Empty.ToString().PadLeft(8, ' '), 
                MaxPassengers.ToString().PadLeft(8, ' '), 
                NoOfWheeels.ToString().PadLeft(8, ' '), 
                Milage.ToString().PadLeft(8, ' '));
        }

        #endregion
    }
}
