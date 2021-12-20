using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFVideoadaptersRepository : IVideoadaptersRepository
    {
        private readonly AppDbContext context;
        public EFVideoadaptersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Videoadapter> GetVideoadapters()
        {
            return context.Videoadapters;
        }

        public Videoadapter GetVideoadapterById(Guid id)
        {
            return context.Videoadapters.FirstOrDefault(x => x.Id == id);
        }

        public void SaveVideoadapter(Videoadapter entity)
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

        public void DeleteVideoadapter(Guid id)
        {
            context.Videoadapters.Remove(new Videoadapter() { Id = id });
            context.SaveChanges();
        }

        // -------------------------------

        public IQueryable<Videoadapter> GetVideoadaptersBySocket(Guid id)
        {
            var videoadapterInterface = "";
            if (context.Motherboards.FirstOrDefault(x => x.Id == id) != null)
            {
                videoadapterInterface = context.Motherboards.FirstOrDefault(x => x.Id == id).VideoadapterInterface;
            }
            return context.Videoadapters.Where(x => x.Interface == videoadapterInterface);
        }
    }
}
