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

        public async Task<List<BoardSlot>> ValidateBoardSlots(
           List<BoardSlot> boardSlots,
           string? userId)
        {
            var works = await repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToListAsync();

            var additionalCards = new List<AdditionalCard>();

            if (!string.IsNullOrWhiteSpace(userId))
            {
                additionalCards = await repository
                    .AllReadОnly<AdditionalCard>()
                    .Where(c => c.UserId == userId)
                    .ToListAsync();
            }

            foreach (var section in boardSlots
                .Select(s => s.Section)
                .Distinct())
            {
                var cards = boardSlots
                    .Where(bs => bs.Section == section)
                    .Select(bs => bs.Card)
                    .Where(c => c != null)
                    .ToList();

                int titleCount = cards.Count(c => c!.Type == "Title");

                if (titleCount > 1 || titleCount == 0)
                {
                    foreach (var card in cards)
                    {
                        card!.IsCorrect = false;
                    }

                    continue;
                }

                var titleCard = cards.First(c => c!.Type == "Title")!;

                var correspondingWork = works
                    .FirstOrDefault(w => w.Id == titleCard.WorkId);

                if (correspondingWork == null)
                {
                    foreach (var card in cards)
                    {
                        card!.IsCorrect = false;
                    }

                    continue;
                }

                titleCard.IsCorrect = true;

                ValidateCardsByType(
                    cards!,
                    "Author",
                    correspondingWork.Author.PhotoPath);

                ValidateCardsByType(
                    cards!,
                    "Literary Direction",
                    correspondingWork.LiteraryDirection.Name);

                ValidateCardsByType(
                    cards!,
                    "Genre",
                    correspondingWork.Genre.Name);

                ValidateCardsByType(
                    cards!,
                    "Character",
                    correspondingWork.Characters);

                ValidateCardsByType(
                    cards!,
                    "Category",
                    correspondingWork.Category.Name);

                ValidateAdditionalCards(
                    cards!,
                    correspondingWork.Id,
                    additionalCards);
            }

            return boardSlots;
        }

        private void ValidateCardsByType(
            List<Card> cards,
            string type,
            string correctValue)
        {
            bool isAlreadyCorrect = false;

            foreach (var card in cards.Where(c => c.Type == type))
            {
                if (card.WorkId > 0 &&
                    card.Content == correctValue &&
                    !isAlreadyCorrect)
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

        private void ValidateAdditionalCards(
            List<Card> cards,
            int workId,
            List<AdditionalCard> additionalCards)
        {
            foreach (var card in cards.Where(c => c.IsAdditional))
            {
                var matchingAdditionalCard = additionalCards.FirstOrDefault(c =>
                    c.WorkId == workId &&
                    c.Type == card.Type &&
                    c.Content == card.Content);

                card.IsCorrect = matchingAdditionalCard != null;
            }
        }

        public Dictionary<int, List<Card>> BuildSolutionsAsync(List<BoardSlot> boardSlots, string? userId)
        {
            var works = repository
                .AllReadОnly<Work>()
                .Include(w => w.Author)
                .Include(w => w.Genre)
                .Include(w => w.LiteraryDirection)
                .Include(w => w.Category)
                .ToList();

            var additionalCards = new List<AdditionalCard>();

            if (!string.IsNullOrWhiteSpace(userId))
            {
                additionalCards = repository
                    .AllReadОnly<AdditionalCard>()
                    .Where(c => c.UserId == userId)
                    .ToList();
            }

            var solutions = new Dictionary<int, List<Card>>();

            foreach (var section in boardSlots.Select(s => s.Section).Distinct())
            {
                var sectionSlots = boardSlots
                    .Where(s => s.Section == section)
                    .ToList();

                var titleCard = sectionSlots
                    .Select(s => s.Card)
                    .FirstOrDefault(c => c != null && c.Type == "Title");

                if (titleCard == null)
                    continue;

                var work = works.FirstOrDefault(w => w.Id == titleCard.WorkId);
                if (work == null)
                    continue;

                var solutionCards = new List<Card>
                {
                    new Card { WorkId = work.Id, Type = "Title", Content = work.Title },
                    new Card
                    {
                        WorkId = work.Id,
                        Type = "Author",
                        Content = work.Author.PhotoPath,
                        MoreInformationUrl = work.Author.MoreInformationUrl
                    },
                    new Card { WorkId = work.Id, Type = "Literary Direction", Content = work.LiteraryDirection.Name },
                    new Card { WorkId = work.Id, Type = "Category", Content = work.Category.Name },
                    new Card { WorkId = work.Id, Type = "Genre", Content = work.Genre.Name },
                    new Card { WorkId = work.Id, Type = "Character", Content = work.Characters }
                };

                solutionCards.AddRange(
                    additionalCards
                        .Where(c => c.WorkId == work.Id)
                        .Select(c => new Card
                        {
                            WorkId = c.WorkId,
                            Type = c.Type,
                            Content = c.Content,
                            IsAdditional = true
                        }));

                solutions[section] = solutionCards;
            }

            return solutions;
        }
    }
}
