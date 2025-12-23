using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
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

        public async Task<List<Card>> GenerateDeckAsync()
        {
            var works = await repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToListAsync();

            var cards = new List<Card>();
            foreach (var work in works)
            {
                cards.Add(new Card
                {
                    Type = "Title",
                    Content = work.Title
                });

                cards.Add(new Card
                {
                    Type = "Author",
                    Content = work.Author.PhotoPath
                });

                cards.Add(new Card
                {
                    Type = "Literary Direction",
                    Content = work.LiteraryDirection.Name
                });
                
                cards.Add(new Card
                {
                    Type = "Category",
                    Content = work.Category.Name
                });

                cards.Add(new Card
                {
                    Type = "Genre",
                    Content = work.Genre.Name
                });

                cards.Add(new Card
                {
                    Type = "Character",
                    Content = work.Characters
                });
            }

            return await ShuffleDeckAsync(cards);
        }

        public async Task<List<Card>> ShuffleDeckAsync(List<Card> cards)
        {
            Random rnd = new Random();

            return cards.OrderBy(c => rnd.Next()).ToList();
        }
    }
}
