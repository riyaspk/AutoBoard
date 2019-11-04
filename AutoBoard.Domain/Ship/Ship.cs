using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Ship 
    /// </summary>
    public class Ship : Vehicle
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
        /// Gets or sets the model identifier.
        /// </summary>
        /// <value>
        /// The model identifier.
        /// </value>
        public int ModelId { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public Model Model { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        #region  Methods

        /// <summary>
        /// Print output
        /// </summary>
        /// <returns></returns>
        public override string Print()
        {
            return string.Format("Reg.ID={0}, Make={1}, Model={2}, MaxPassengers={3}, Milage={4}, Efficiancy={5}",
                 RegistrationID.ToString().PadLeft(4, '0'),
                Make != null ? Make.Name.ToString().PadLeft(5, ' ') : string.Empty.ToString().PadLeft(8, ' '),
                string.Empty.PadLeft(15, ' '),
                MaxPassengers.ToString().PadLeft(2, '0'),
                Milage.ToString().PadLeft(2, '0'),
                CalculateFuelEfficiancy().ToString().PadLeft(2, '0'));
        }

        #endregion
    }
}
