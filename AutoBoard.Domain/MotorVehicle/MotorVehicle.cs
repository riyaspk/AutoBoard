using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the model identifier.
        /// </summary>
        /// <value>
        /// The model identifier.
        /// </value>
        public int ModelId { get; set; }

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
        public float EngineSize { get; set; }

        #region  Methods

        /// <summary>
        /// Print output
        /// </summary>
        /// <returns></returns>
        public override string Print()
        {
            return string.Format("Reg.ID={0}, Make={1}, Model={2}, MaxPassengers={3}, Milage={5}, Efficiancy={5}",
                RegistrationID.ToString().PadLeft(4,'0'), 
                Make != null ? Make.Name.ToString().PadLeft(5, ' ') : string.Empty.ToString().PadLeft(8, ' '), 
                MotorVehicleModel != null ? MotorVehicleModel.Name.ToString().PadLeft(15, ' ') : string.Empty.ToString().PadLeft(8, ' '), 
                MaxPassengers.ToString().PadLeft(2, '0'),
                Milage.ToString().PadLeft(2, '0'), 
                CalculateFuelEfficiancy().ToString().PadLeft(2, '0'));
        }

        #endregion
    }
}
