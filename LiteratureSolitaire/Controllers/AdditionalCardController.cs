using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureSolitaire.Controllers
{
    [Authorize]
    public class AdditionalCardController : Controller
    {
        private readonly IAdditionalCardService additionalCardService;

        public AdditionalCardController(IAdditionalCardService _additionalCardService)
        {
            additionalCardService = _additionalCardService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = User.GetUserId();

            var model = await additionalCardService
                .GetPageDataAsync(userId);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(
            int workId,
            string type,
            string content)
        {
            var userId = User.GetUserId();

            if (string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(content))
            {
                return RedirectToAction(nameof(Index));
            }

            await additionalCardService.AddAsync(
                userId,
                workId,
                type,
                content);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = User.GetUserId();

            await additionalCardService.DeleteAsync(
                id,
                userId);

            return RedirectToAction(nameof(Index));
        }
    }
}
