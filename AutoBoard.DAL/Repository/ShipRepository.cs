using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.Ship}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IShipRepository" />
    public class ShipRepository : BaseRepository<Ship>, IShipRepository
    {
    }
}
