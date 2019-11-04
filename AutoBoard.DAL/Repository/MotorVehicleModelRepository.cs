using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// MotorVehicleModelRepository
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.MotorVehicleModel}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IMotorVehicleModelRepository" />
    public class MotorVehicleModelRepository: BaseRepository<MotorVehicleModel>, IMotorVehicleModelRepository
    {
    }
}
