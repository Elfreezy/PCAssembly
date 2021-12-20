using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface ISoundCardsRepository
    {
        IQueryable<SoundCard> GetSoundCards();
        SoundCard GetSoundCardById(Guid id);
        void SaveSoundCard(SoundCard entity);
        void DeleteSoundCard(Guid id);

        IQueryable<SoundCard> GetSoundCardsBySocket(Guid id);
    }
}
