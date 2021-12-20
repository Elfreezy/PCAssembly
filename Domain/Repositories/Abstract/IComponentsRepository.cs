using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IComponentsRepository
    {
        IQueryable<Component> GetComponents();
        Component GetComponentById(Guid id);
        void SaveComponent(Component entity);
        void DeleteComponent(Guid id);
    }
}
