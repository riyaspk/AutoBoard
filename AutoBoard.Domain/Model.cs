using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Vehicle.Model
    /// </summary>
    public abstract class Model
    {
        /// <summary>
        /// Gets or sets the model identifier.
        /// </summary>
        /// <value>
        /// The model identifier.
        /// </value>
        [Key]
        public int ModelId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the warranty.
        /// </summary>
        /// <value>
        /// The warranty.
        /// </value>
        public string Warranty { get; set; }
    }
}
