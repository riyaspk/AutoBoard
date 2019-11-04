using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Vehicle.MotorVehicleModel
    /// </summary>
    public class MotorVehicleModel: Model
    {
        /// <summary>
        /// Gets or sets the type of the body.
        /// </summary>
        /// <value>
        /// The type of the body.
        /// </value>
        public string BodyType { get; set; }

        /// <summary>
        /// Gets or sets the transmission.
        /// </summary>
        /// <value>
        /// The transmission.
        /// </value>
        /// <example>Manual, Auto</example>
        public string Transmission { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the doors.
        /// </summary>
        /// <value>
        /// The doors.
        /// </value>
        public int Doors { get; set; }

        /// <summary>
        /// Gets or sets the type of the fuel.
        /// </summary>
        /// <value>
        /// The type of the fuel.
        /// </value>
        /// <example>Petrol, Diesel, Electric, Hybrid</example>
        public string FuelType { get; set; }
    }
}
