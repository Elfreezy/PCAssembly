using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IMotherboardsRepository
    {
        IQueryable<Motherboard> GetMotherboards();
        Motherboard GetMotherboardById(Guid id);
        void SaveMotherboard(Motherboard entity);
        void DeleteMotherboard(Guid id);

        IQueryable<Motherboard> GetMotherboardsBySocket(Guid id);
    }
}
