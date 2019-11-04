using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoBoard.Domain
{
    /// <summary>
    /// Class for Vehicle.Make
    /// </summary>
    public class Make
    {
        /// <summary>
        /// Gets or sets the make identifier.
        /// </summary>
        /// <value>
        /// The make identifier.
        /// </value>
        [Key]
        public int MakeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        /// <example>BMW, Ford, Toyota etc</example>
        [Required]
        public string Name { get; set; }

        // Other properties
    }
}
