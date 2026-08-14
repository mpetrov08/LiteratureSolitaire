using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Enumerations;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Extensions;
using LiteratureSolitaire.Infrastructure.Data.Models;
using LiteratureSolitaire.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Services
{
    public class DeckService : IDeckService
    {
        private readonly IRepository repository;

        public DeckService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<List<Work>> FilterCards(List<CategorySorting>? categories = null)
        {
            var works = await repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToListAsync();

            if (categories != null && categories.Any())
            {
                var selectedNames = categories
                    .Select(c => c.GetDisplayName())
                    .ToList();

                works = works
                    .Where(w => selectedNames.Contains(w.Category.Name))
                    .ToList();
            }

            return works;
        }
        public async Task<List<Card>> GenerateDeckAsync(List<CategorySorting>? categories = null, string? userId = null)
        {
            var works = await FilterCards(categories);

            var workIds = works
                            .Select(w => w.Id)
                            .ToHashSet();

            var cards = new List<Card>();
            foreach (var work in works)
            {
                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Title",
                    Content = work.Title
                });

                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Author",
                    Content = work.Author.PhotoPath,
                    MoreInformationUrl = work.Author.MoreInformationUrl
                });

                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Literary Direction",
                    Content = work.LiteraryDirection.Name
                });
                
                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Category",
                    Content = work.Category.Name
                });

                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Genre",
                    Content = work.Genre.Name
                });

                cards.Add(new Card
                {
                    WorkId = work.Id,
                    Type = "Character",
                    Content = work.Characters
                });
            }

            if (!string.IsNullOrWhiteSpace(userId))
            {
                var additionalCards = await repository
                                        .AllReadОnly<AdditionalCard>()
                                        .Where(c => c.UserId == userId && workIds.Contains(c.WorkId))
                                        .ToListAsync();

                foreach (var additionalCard in additionalCards)
                {
                    cards.Add(new Card
                    {
                        WorkId = additionalCard.WorkId,
                        Type = additionalCard.Type,
                        Content = additionalCard.Content,
                        IsAdditional = true
                    });
                }
            }

            return await ShuffleDeckAsync(cards);
        }

        public async Task<List<Card>> ShuffleDeckAsync(List<Card> cards)
        {
            var rnd = Random.Shared;

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }

            return cards;
        }
    }
}