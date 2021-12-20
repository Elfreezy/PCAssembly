using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFPowerUnitsRepository : IPowerUnitsRepository
    {
        private readonly AppDbContext context;
        public EFPowerUnitsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<PowerUnit> GetPowerUnits()
        {
            return context.PowerUnits;
        }

        public PowerUnit GetPowerUnitById(Guid id)
        {
            return context.PowerUnits.FirstOrDefault(x => x.Id == id);
        }

        public void SavePowerUnit(PowerUnit entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeletePowerUnit(Guid id)
        {
            context.PowerUnits.Remove(new PowerUnit() { Id = id });
            context.SaveChanges();
        }

        // -------------------------------

        public IQueryable<PowerUnit> GetPowerUnitsBySocket(Guid id)
        {
            var formFactorPowerUnit = "";
            if (context.Motherboards.FirstOrDefault(x => x.Id == id) != null)
            {
                formFactorPowerUnit = context.Motherboards.FirstOrDefault(x => x.Id == id).FormFactorPowerUnit;
            }
            return context.PowerUnits.Where(x => x.FormFactor == formFactorPowerUnit);
        }
    }
}
