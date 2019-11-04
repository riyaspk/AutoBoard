using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Bicycle 
    /// </summary>
    public class Bicycle : Vehicle
    {
        /// <summary>
        /// Gets or sets the model identifier.
        /// </summary>
        /// <value>
        /// The model identifier.
        /// </value>
        public int ModelId { get; set; }

        /// <summary>
        /// Gets or sets the bicycle model.
        /// </summary>
        /// <value>
        /// The bicycle model.
        /// </value>
        public BicycleModel BicycleModel { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        /// <example>Road Bikes, Road Frames, Groupsets, Road Tyres etc</example>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the type of the material.
        /// </summary>
        /// <value>
        /// The type of the material.
        /// </value>
        public string MaterialType { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public float Weight { get; set; }

        /// <summary>
        /// Print output
        /// </summary>
        /// <returns></returns>
        public override string Print()
        {
            return string.Format("Reg.ID={0}, Make={1}, Model={2}, MaxPassengers={3}, NoOfWheeels={4}, Efficiancy={5}",
                string.Empty.PadLeft(4, '0'),
                Make != null ? Make.Name.ToString().PadLeft(5, ' ') : string.Empty.ToString().PadLeft(8, ' '),
                BicycleModel != null ? BicycleModel.Name.ToString().PadLeft(15, ' ') : string.Empty.ToString().PadLeft(8, ' '),
                MaxPassengers.ToString().PadLeft(2, '0'),
                NoOfWheeels.ToString().PadLeft(2, '0'),
                CalculateFuelEfficiancy().ToString().PadLeft(2, '0'));
        }
    }
}
