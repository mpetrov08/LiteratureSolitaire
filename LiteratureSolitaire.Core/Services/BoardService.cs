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

                var authorCard = cards.FirstOrDefault(c => c.Type == "Author");
                var correctAuthor = correspondingWork.Author.PhotoPath;

                var literaryDirectionCard = cards.FirstOrDefault(c => c.Type == "Literary Direction");
                var correctLiteraryDirection = correspondingWork.LiteraryDirection.Name;

                var genreCard = cards.FirstOrDefault(c => c.Type == "Genre");
                var correctGenre = correspondingWork.Genre.Name;

                var characterCard = cards.FirstOrDefault(c => c.Type == "Character");
                var correctCharacters = correspondingWork.Characters;

                var categoryCard = cards.FirstOrDefault(c => c.Type == "Category");
                var correctCategory = correspondingWork.Category.Name;

                if (authorCard != null && authorCard.Content == correctAuthor)
                {
                    authorCard.IsCorrect = true;
                }
                else if (authorCard != null)
                {
                    authorCard.IsCorrect = false;
                }

                if (literaryDirectionCard != null && literaryDirectionCard.Content == correctLiteraryDirection)
                {
                    literaryDirectionCard.IsCorrect = true;
                }
                else if(literaryDirectionCard != null)
                {
                    literaryDirectionCard.IsCorrect = false;
                }

                if (genreCard != null && genreCard.Content == correctGenre)
                {
                    genreCard.IsCorrect = true;
                }
                else if (genreCard != null)
                {
                    genreCard.IsCorrect = false;
                }

                if (characterCard != null && characterCard.Content == correctCharacters)
                {
                    characterCard.IsCorrect = true;
                }
                else if (characterCard != null)
                {
                    characterCard.IsCorrect = false;
                }

                if (categoryCard != null && categoryCard.Content == correctCategory)
                {
                    categoryCard.IsCorrect = true;
                }
                else if (categoryCard != null)
                {
                    categoryCard.IsCorrect = false;
                }
            }

            return boardSlots;
        }
    }
}
