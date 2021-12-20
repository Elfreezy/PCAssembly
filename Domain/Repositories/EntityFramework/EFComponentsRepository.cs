using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFComponentsRepository : IComponentsRepository
    {
        private readonly AppDbContext context;
        public EFComponentsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Component> GetComponents()
        {
            return context.Components;
        }

        public Component GetComponentById(Guid id)
        {
            return context.Components.FirstOrDefault(x => x.Id == id);
        }

        public void SaveComponent(Component entity)
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

        public void DeleteComponent(Guid id)
        {
            context.Components.Remove(new Component() { Id = id });
            context.SaveChanges();
        }


    }
}
