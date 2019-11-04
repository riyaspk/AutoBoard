using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// BicycleRepository
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.Bicycle}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IBicycleRepository" />
    public class BicycleRepository : BaseRepository<Bicycle>, IBicycleRepository
    {
    }
}
