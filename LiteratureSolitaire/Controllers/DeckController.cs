using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Core.Services;
using LiteratureSolitaire.Extensions;
using LiteratureSolitaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureSolitaire.Controllers
{
    public class DeckController : Controller
    {
        private readonly IDeckService deckService;
        private readonly IBoardService boardService;

        public DeckController(IDeckService _deckService, IBoardService _boardService)
        {
            deckService = _deckService;
            boardService = _boardService;
        }

        private const string DeckSessionKey = "deck";


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var deck = HttpContext.Session.GetObjectFromJson<List<Card>>("deck");
            var drawn = HttpContext.Session.GetObjectFromJson<List<Card>>("drawn") ?? new();
            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board");

            if (deck == null || board == null)
            {
                deck = await deckService.GenerateDeckAsync();
                drawn = new List<Card>();

                board = Enumerable.Range(1, 27)
                    .SelectMany(s => Enumerable.Range(1, 6)
                        .Select(p => new BoardSlot
                        {
                            Section = s,
                            Position = p,
                            Card = null
                        }))
                    .ToList();

                HttpContext.Session.SetObjectAsJson("deck", deck);
                HttpContext.Session.SetObjectAsJson("drawn", drawn);
                HttpContext.Session.SetObjectAsJson("board", board);

                return View();
            }

            var boardCardIds = board
                .Where(s => s.Card != null)
                .Select(s => s.Card!.Id)
                .ToHashSet();

            drawn = drawn
                .Where(c => !boardCardIds.Contains(c.Id))
                .ToList();

            HttpContext.Session.SetObjectAsJson("drawn", drawn);

            return View();
        }

        [HttpPost]
        public IActionResult DrawCard()
        {
            var cards = HttpContext.Session.GetObjectFromJson<List<Card>>(DeckSessionKey);
            if (cards == null || cards.Count == 0)
            {
                TempData["Message"] = "Тестето е празно";
                return RedirectToAction("Index");
            }

            var drawnCard = cards.First();
            cards.RemoveAt(0);

            HttpContext.Session.SetObjectAsJson(DeckSessionKey, cards);
            TempData["DrawnCard"] = $"{drawnCard.Content}";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DrawCardAjax()
        {
            var deck = HttpContext.Session.GetObjectFromJson<List<Card>>("deck") ?? new();
            var drawn = HttpContext.Session.GetObjectFromJson<List<Card>>("drawn") ?? new();
            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board") ?? new();

            drawn = drawn
                .GroupBy(c => c.Id)
                .Select(g => g.First())
                .ToList();

            var boardIds = board
                .Where(s => s.Card != null)
                .Select(s => s.Card!.Id)
                .ToHashSet();

            drawn = drawn
                .Where(c => !boardIds.Contains(c.Id))
                .ToList();

            if (drawn.Count >= 5)
                return Content("LIMIT");

            if (deck.Count == 0)
                return Content("EMPTY");

            var card = deck[0];
            deck.RemoveAt(0);
            drawn.Add(card);

            HttpContext.Session.SetObjectAsJson("deck", deck);
            HttpContext.Session.SetObjectAsJson("drawn", drawn);

            return PartialView("_CardPartial", card);
        }

        [HttpPost]
        public IActionResult PlaceCard([FromBody] PlaceCardDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.CardId))
                return BadRequest();

            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board") ?? new();
            var drawn = HttpContext.Session.GetObjectFromJson<List<Card>>("drawn") ?? new();

            var targetSlot = board.FirstOrDefault(s =>
                s.Section == dto.Section && s.Position == dto.Position);

            if (targetSlot == null)
                return BadRequest();

            var movingCard =
                drawn.FirstOrDefault(c => c.Id == dto.CardId)
                ?? board.FirstOrDefault(s => s.Card?.Id == dto.CardId)?.Card;

            if (movingCard == null)
                return NotFound();

            var sourceSlot = board.FirstOrDefault(s => s.Card?.Id == dto.CardId);

            var targetCard = targetSlot.Card;

            drawn.RemoveAll(c => c.Id == movingCard.Id);
            if (sourceSlot != null)
                sourceSlot.Card = null;

            if (targetCard != null)
            {
                if (sourceSlot != null)
                {
                    sourceSlot.Card = targetCard;
                }
                else
                {
                    drawn.Add(targetCard);
                }
            }

            targetSlot.Card = movingCard;

            HttpContext.Session.SetObjectAsJson("board", board);
            HttpContext.Session.SetObjectAsJson("drawn", drawn);

            return Ok();
        }

        [HttpPost]
        public IActionResult ReturnToDrawPile([FromBody] PlaceCardDto dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.CardId))
                return BadRequest();

            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board") ?? new();
            var drawn = HttpContext.Session.GetObjectFromJson<List<Card>>("drawn") ?? new();

            var slotWithCard = board.FirstOrDefault(s => s.Card?.Id == dto.CardId);
            var card = slotWithCard?.Card;

            if (card == null)
                return Ok();

            if (drawn.Count >= 5)
                return BadRequest("LIMIT");

            slotWithCard!.Card = null;

            if (!drawn.Any(c => c.Id == card.Id))
                drawn.Add(card);

            HttpContext.Session.SetObjectAsJson("board", board);
            HttpContext.Session.SetObjectAsJson("drawn", drawn);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Shuffle()
        {
            var allCards = await deckService.GenerateDeckAsync();
            allCards = await deckService.ShuffleDeckAsync(allCards);

            foreach (var c in allCards)
            {
                c.IsCorrect = false;
                c.IsCorrectChecked = false;
            }

            HttpContext.Session.SetObjectAsJson("deck", allCards);
            HttpContext.Session.SetObjectAsJson("drawn", new List<Card>());

            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board");
            foreach (var slot in board)
                slot.Card = null;

            HttpContext.Session.SetObjectAsJson("board", board);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ValidateBoard()
        {
            var board = HttpContext.Session.GetObjectFromJson<List<BoardSlot>>("board");
            var drawn = HttpContext.Session.GetObjectFromJson<List<Card>>("drawn") ?? new();
            if (board == null)
            {
                TempData["Message"] = "Дъската е празна.";
                return RedirectToAction("Index");
            }

            var checkedBoard = await boardService.ValidateBoardSlots(board);

            foreach (var slot in checkedBoard)
            {
                if (slot.Card != null)
                    slot.Card.IsCorrectChecked = true;
            }

            foreach (var card in drawn)
            {
                card.IsCorrectChecked = true;
                card.IsCorrect = false;
            }

            int correctCount = checkedBoard.Count(s => s.Card != null && s.Card.IsCorrect == true);
            TempData["CorrectCount"] = correctCount;

            HttpContext.Session.SetObjectAsJson("board", checkedBoard);
            HttpContext.Session.SetObjectAsJson("drawn", drawn);

            return RedirectToAction("Index");
        }
    }
}
