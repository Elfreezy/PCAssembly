using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IVideoadaptersRepository
    {
        IQueryable<Videoadapter> GetVideoadapters();
        Videoadapter GetVideoadapterById(Guid id);
        void SaveVideoadapter(Videoadapter entity);
        void DeleteVideoadapter(Guid id);

        IQueryable<Videoadapter> GetVideoadaptersBySocket(Guid id);
    }
}
