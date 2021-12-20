using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFMotherboardsRepository : IMotherboardsRepository
    {
        private readonly AppDbContext context;
        public EFMotherboardsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Motherboard> GetMotherboards()
        {
            return context.Motherboards;
        }

        public Motherboard GetMotherboardById(Guid id)
        {
            return context.Motherboards.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMotherboard(Motherboard entity)
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

        public void DeleteMotherboard(Guid id)
        {
            context.Motherboards.Remove(new Motherboard() { Id = id });
            context.SaveChanges();
        }

        // -------------------------------

        public IQueryable<Motherboard> GetMotherboardsBySocket(Guid id)
        {
            var processorSocket = "";
            if (context.Processors.FirstOrDefault(x => x.Id == id) != null)
            {
                processorSocket = context.Processors.FirstOrDefault(x => x.Id == id).Socket;
            }
            return context.Motherboards.Where(x => x.ProcessorSocket == processorSocket);
        }
    }
}
