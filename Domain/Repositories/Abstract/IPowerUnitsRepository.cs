using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IPowerUnitsRepository
    {
        IQueryable<PowerUnit> GetPowerUnits();
        PowerUnit GetPowerUnitById(Guid id);
        void SavePowerUnit(PowerUnit entity);
        void DeletePowerUnit(Guid id);

        IQueryable<PowerUnit> GetPowerUnitsBySocket(Guid id);
    }
}
