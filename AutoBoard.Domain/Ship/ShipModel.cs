using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for ShipModel
    /// </summary>
    /// <seealso cref="AutoBoard.Domain.Model" />
    public class ShipModel: Model
    {
        /// <summary>
        /// Gets or sets the type of the body.
        /// </summary>
        /// <value>
        /// The type of the body.
        /// </value>
        public string BodyType { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color { get; set; }
    }
}
