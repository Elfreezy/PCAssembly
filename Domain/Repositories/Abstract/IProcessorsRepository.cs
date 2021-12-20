using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IProcessorsRepository
    {
        IQueryable<Processor> GetProcessors();
        IQueryable<Motherboard> GetMotherboardsBySocket(Guid id);
        Processor GetProcessorById(Guid id);
        void SaveProcessor(Processor entity);
        void DeleteProcessor(Guid id);
    }
}
