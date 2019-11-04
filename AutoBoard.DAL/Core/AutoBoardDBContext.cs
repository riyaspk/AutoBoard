using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoBoard.Domain;

namespace AutoBoard.DAL
{
    /// <summary>
    /// AutoBoardDBContext for database operations
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class AutoBoardDBContext: DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoBoardDBContext"/> class.
        /// </summary>
        public AutoBoardDBContext() : base("name=AutoBoardDBContext")
        {

        }

        /// <summary>
        /// Gets or sets the bicycles.
        /// </summary>
        /// <value>
        /// The bicycles.
        /// </value>
        public DbSet<Bicycle> Bicycles { get; set; }

        /// <summary>
        /// Gets or sets the bicycle models.
        /// </summary>
        /// <value>
        /// The bicycle models.
        /// </value>
        public DbSet<BicycleModel> BicycleModels { get; set; }

        /// <summary>
        /// Gets or sets the motor vehicle models.
        /// </summary>
        /// <value>
        /// The motor vehicle models.
        /// </value>
        public DbSet<MotorVehicleModel> MotorVehicleModels { get; set; }

        /// <summary>
        /// Gets or sets the ships.
        /// </summary>
        /// <value>
        /// The ships.
        /// </value>
        public DbSet<Ship> Ships { get; set; }

        /// <summary>
        /// Gets or sets the ship models.
        /// </summary>
        /// <value>
        /// The ship models.
        /// </value>
        public DbSet<ShipModel> ShipModels { get; set; }

        /// <summary>
        /// Gets or sets the makes.
        /// </summary>
        /// <value>
        /// The makes.
        /// </value>
        public DbSet<Make> Makes { get; set; }

    }
}
