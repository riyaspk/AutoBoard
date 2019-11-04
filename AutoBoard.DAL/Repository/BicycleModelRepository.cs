using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// BicycleModelRepository
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.BicycleModel}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IBicycleModelRepository" />
    public class BicycleModelRepository : BaseRepository<BicycleModel>, IBicycleModelRepository
    {
    }
}
