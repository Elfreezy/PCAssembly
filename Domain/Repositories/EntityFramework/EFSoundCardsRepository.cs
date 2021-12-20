using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFSoundCardsRepository : ISoundCardsRepository
    {
        private readonly AppDbContext context;
        public EFSoundCardsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<SoundCard> GetSoundCards()
        {
            return context.SoundCards;
        }

        public SoundCard GetSoundCardById(Guid id)
        {
            return context.SoundCards.FirstOrDefault(x => x.Id == id);
        }

        public void SaveSoundCard(SoundCard entity)
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

        public void DeleteSoundCard(Guid id)
        {
            context.SoundCards.Remove(new SoundCard() { Id = id });
            context.SaveChanges();
        }

        // -------------------------------

        public IQueryable<SoundCard> GetSoundCardsBySocket(Guid id)
        {
            var formFactorSoundCard = "";
            if (context.Motherboards.FirstOrDefault(x => x.Id == id) != null)
            {
                formFactorSoundCard = context.Motherboards.FirstOrDefault(x => x.Id == id).FormFactorSoundCard;
            }
            return context.SoundCards.Where(x => x.FormFactor == formFactorSoundCard);
        }
    }
}
