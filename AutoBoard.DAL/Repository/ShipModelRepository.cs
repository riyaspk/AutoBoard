using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// ShipModelRepository
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.ShipModel}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IShipModelRepository" />
    public class ShipModelRepository : BaseRepository<ShipModel>, IShipModelRepository
    {
    }
}
