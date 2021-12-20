using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFProcessorsRepository : IProcessorsRepository
    {
        private readonly AppDbContext context;
        public EFProcessorsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Processor> GetProcessors()
        {
            return context.Processors;
        }

        public Processor GetProcessorById(Guid id)
        {
            return context.Processors.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<Motherboard> GetMotherboardsBySocket(Guid id)
        {
            var processorSocket = context.Processors.FirstOrDefault(x => x.Id == id).Socket;
            return context.Motherboards.Where(x => x.ProcessorSocket == processorSocket);
        }
        public IQueryable<Processor> GetProcessorsByMotherboard(Guid id)
        {
            var processorSocket = context.Motherboard.FirstOrDefault(x => x.Id == id).ProcessorSocket;
            return context.Processors.Where(x => x.Socket == processorSocket);
        }

        public void SaveProcessor(Processor entity)
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

        public void DeleteProcessor(Guid id)
        {
            context.Processors.Remove(new Processor() { Id = id });
            context.SaveChanges();
        }
    }
}
