using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Infrastructure.Data.Models;
using LiteratureSolitaire.Infrastructure.Repository;
using LiteratureSolitaire.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Services
{
    public class BoardService : IBoardService
    {
        private readonly IRepository repository;

        public BoardService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<List<BoardSlot>> ValidateBoardSlots(List<BoardSlot> boardSlots)
        {
            var works = await repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToListAsync();

            for (int section = 1; section <= 27; section++)
            {
                var cards = boardSlots
                    .Where(bs => bs.Section == section)
                    .Select(bs => bs.Card)
                    .Where(c => c != null)
                    .ToList();

                int titleCount = cards.Count(c => c.Type == "Title");
                if (titleCount > 1 || titleCount == 0)
                {
                    foreach (var card in cards)
                    {
                        card.IsCorrect = false;
                    }

                    continue;
                }

                var titleCard = cards.FirstOrDefault(c => c.Type == "Title");
                var correspondingWork = works.FirstOrDefault(w => w.Title == titleCard.Content);
                titleCard.IsCorrect = true;

                var correctAuthor = correspondingWork.Author.PhotoPath;
                ValidateCardsByType(cards, "Author", correctAuthor);

                var correctLiteraryDirection = correspondingWork.LiteraryDirection.Name;
                ValidateCardsByType(cards, "Literary Direction", correctLiteraryDirection);

                var correctGenre = correspondingWork.Genre.Name;
                ValidateCardsByType(cards, "Genre", correctGenre);

                var correctCharacters = correspondingWork.Characters;
                ValidateCardsByType(cards, "Character", correctCharacters);

                var correctCategory = correspondingWork.Category.Name;
                ValidateCardsByType(cards, "Category", correctCategory);
            }

            return boardSlots;
        }

        private void ValidateCardsByType(List<Card> cards, string type, string correctValue)
        {
            bool isAlreadyCorrect = false;

            foreach (var card in cards.Where(c => c.Type == type))
            {
                if (card.Content == correctValue && !isAlreadyCorrect)
                {
                    card.IsCorrect = true;
                    isAlreadyCorrect = true;
                }
                else
                {
                    card.IsCorrect = false;
                }
            }
        }
    }
}
