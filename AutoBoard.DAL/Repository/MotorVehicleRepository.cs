using AutoBoard.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.DAL
{
    /// <summary>
    /// MotorVehicleRepository
    /// </summary>
    /// <seealso cref="AutoBoard.DAL.BaseRepository{AutoBoard.Domain.MotorVehicle}" />
    /// <seealso cref="AutoBoard.DAL.Interfaces.IMotorVehicleRepository" />
    public class MotorVehicleRepository: BaseRepository<MotorVehicle>, IMotorVehicleRepository
    {
    }
}
