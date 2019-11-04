using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Vehicle 
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Identification Number
        /// </summary>
        public int RegistrationID { get; set; }

        /// <summary>
        /// Make of the vehicle
        /// </summary>
        public Make Make { get; set; }

        /// <summary>
        /// Max Passengers can accomodate 
        /// </summary>
        public int MaxPassengers { get; set; }

        /// <summary>
        /// No. Of Wheels 
        /// </summary>
        public int NoOfWheeels { get; set; }

        /// <summary>
        /// Milage := Kilometer / Litre
        /// </summary>
        public int Milage { get; set; }

        #region  Methods

        /// <summary>
        /// Print output
        /// </summary>
        public abstract string Print();

        /// <summary>
        /// Calculates the fuel efficiancy.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        public virtual float CalculateFuelEfficiancy()
        {
            try
            {
                return (float)Milage / (float)MaxPassengers;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught, invalid values provided to perform the operation, please verify the inputs", ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, something going wrong, please verify the inputs", ex.Message);
                throw ex;
            }
        }

        #endregion
    }
}
