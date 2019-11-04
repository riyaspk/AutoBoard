using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard
{
    /// <summary>
    /// Utility Class to register the vehicles
    /// </summary>
    public static class RegistrationService
    {
        /// <summary>
        /// Gets or sets the register.
        /// </summary>
        /// <value>
        /// The register.
        /// </value>
        public static Dictionary<int, Vehicle> register { get; set; }

        #region ctor
        /// <summary>
        /// Initializes the <see cref="RegistrationService"/> class.
        /// </summary>
        static RegistrationService()
        {
            register = new Dictionary<int, Vehicle>();
        }

        #endregion

        /// <summary>
        /// Creates new rigstrationnumber.
        /// </summary>
        /// <returns></returns>
        public static int NewRigstrationNumber()
        {
            // Registration starting from 1000
            return register.Count() > 0 ? register.Last().Key + 1 : 1000;
        }

        /// <summary>
        /// Rigsters the new vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <exception cref="InvalidOperationException">The RegistrationID already assigned to another vehicle</exception>
        public static void RigsterNewVehicle(Vehicle vehicle)
        {
            if (!register.ContainsKey(vehicle.RegistrationID))
            {
                register.Add(vehicle.RegistrationID, vehicle);
            }
            else
            {
                throw new InvalidOperationException("The RegistrationID already assigned to another vehicle");
            }
        }
    }
}
