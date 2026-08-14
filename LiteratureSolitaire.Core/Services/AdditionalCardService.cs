using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Infrastructure.Data.Models;
using LiteratureSolitaire.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Services
{
    public class AdditionalCardService : IAdditionalCardService
    {
        private readonly IRepository repository;

        public AdditionalCardService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAsync(string userId, int workId, string type, string content)
        {
            var additionalCard = new AdditionalCard
            {
                UserId = userId,
                WorkId = workId,
                Type = type,
                Content = content
            };

            await repository.AddAsync(additionalCard);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, string userId)
        {
            var card = await repository
                .All<AdditionalCard>()
                .FirstOrDefaultAsync(c =>
                    c.Id == id &&
                    c.UserId == userId);

            if (card == null)
                return;

            repository.Delete(card);
            await repository.SaveChangesAsync();
        }

        public async Task<AdditionalCard?> GetByIdAsync(int id, string userId)
        {
            return await repository
                .AllReadОnly<AdditionalCard>()
                .Include(c => c.Work)
                .FirstOrDefaultAsync(c =>
                    c.Id == id &&
                    c.UserId == userId);
        }

        public async Task<List<AdditionalCard>> GetByUserAsync(string userId)
        {
            return await repository
                .AllReadОnly<AdditionalCard>()
                .Include(c => c.Work)
                .Where(c => c.UserId == userId)
                .ToListAsync();
        }

        public async Task<AdditionalCardsViewModel> GetPageDataAsync(string userId)
        {
            var works = await repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToListAsync();

            var additionalCards = await repository
                .AllReadОnly<AdditionalCard>()
                .Where(c => c.UserId == userId)
                .ToListAsync();

            var model = new AdditionalCardsViewModel();

            foreach (var work in works)
            {
                var defaultCards = new List<Card>
        {
            new Card
            {
                WorkId = work.Id,
                Type = "Title",
                Content = work.Title
            },

            new Card
            {
                WorkId = work.Id,
                Type = "Author",
                Content = work.Author.PhotoPath,
                MoreInformationUrl = work.Author.MoreInformationUrl
            },

            new Card
            {
                WorkId = work.Id,
                Type = "Literary Direction",
                Content = work.LiteraryDirection.Name
            },

            new Card
            {
                WorkId = work.Id,
                Type = "Category",
                Content = work.Category.Name
            },

            new Card
            {
                WorkId = work.Id,
                Type = "Genre",
                Content = work.Genre.Name
            },

            new Card
            {
                WorkId = work.Id,
                Type = "Character",
                Content = work.Characters
            }
        };

                model.Works.Add(new AdditionalCardWorkViewModel
                {
                    WorkId = work.Id,
                    WorkTitle = work.Title,
                    DefaultCards = defaultCards,
                    AdditionalCards = additionalCards
                        .Where(c => c.WorkId == work.Id)
                        .ToList()
                });
            }

            return model;
        }
    }
}
