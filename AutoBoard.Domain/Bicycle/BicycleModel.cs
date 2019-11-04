using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for BicycleModel
    /// </summary>
    /// <seealso cref="AutoBoard.Domain.Model" />
    public class BicycleModel : Model
    {
        /// <summary>
        /// Gets or sets the type of the bicycle.
        /// </summary>
        /// <value>
        /// The type of the bicycle.
        /// </value>
        public BicycleType BicycleType { get; set; }

        /// <summary>Gets or sets the age.</summary>
        /// <value>The age.</value>
        /// <example>Adult, etc</example>
        public string Age { get; set; }

        /// <summary>Gets or sets the weight.</summary>
        /// <value>The weight.</value>
        /// <example>27 Kg</example>
        [Range(2, 50, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public float Weight { get; set; }

        /// <summary>
        /// Gets or sets the color of the basket.
        /// </summary>
        /// <value>
        /// The color of the basket.
        /// </value>
        public string BasketColor { get; set; }

        /// <summary>
        /// Gets or sets the shift.
        /// </summary>
        /// <value>
        /// The shift.
        /// </value>
        /// <example>6 speed</example>
        [Range(0, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Shift { get; set; }

        /// <summary>
        /// Gets or sets the height of the adjustable seat.
        /// </summary>
        /// <value>
        /// The height of the adjustable seat.
        /// </value>
        /// <example>80-93cm(from floor to seat)</example>
        public string AdjustableSeatHeight { get; set; }

        /// <summary>
        /// Gets or sets the wheel material.
        /// </summary>
        /// <value>
        /// The wheel material.
        /// </value>
        /// <example>rustproof alloy</example>
        public string WheelMaterial { get; set; }
    }
}
