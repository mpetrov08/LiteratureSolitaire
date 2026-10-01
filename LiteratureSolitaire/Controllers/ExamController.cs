using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Extensions;
using LiteratureSolitaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureSolitaire.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService examService;

        public ExamController(IExamService _examService)
        {
            examService = _examService;
        }

        private const string ExamStateKey = "examState";

        [HttpGet]
        public async Task<IActionResult> Index(List<int>? examSessionIds)
        {
            var state = HttpContext.Session.GetObjectFromJson<ExamState>(ExamStateKey);

            bool sessionsChanged =
                examSessionIds != null &&
                (state == null ||
                 !state.ExamSessionIds.OrderBy(x => x).SequenceEqual(examSessionIds.OrderBy(x => x)));

            if (state == null || sessionsChanged)
            {
                state = await examService.GenerateExamAsync(examSessionIds);
                HttpContext.Session.SetObjectAsJson(ExamStateKey, state);
            }

            var viewModel = await examService.BuildViewModelAsync(state);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SelectAnswer([FromBody] SelectAnswerDto dto)
        {
            var state = HttpContext.Session.GetObjectFromJson<ExamState>(ExamStateKey);

            if (state == null)
                return BadRequest();

            if (state.IsChecked)
                return BadRequest("ALREADY_CHECKED");

            state.SelectedAnswers[dto.QuestionId] = dto.AnswerId;

            HttpContext.Session.SetObjectAsJson(ExamStateKey, state);

            return Ok();
        }

        [HttpPost]
        public IActionResult Validate()
        {
            var state = HttpContext.Session.GetObjectFromJson<ExamState>(ExamStateKey);

            if (state == null)
                return RedirectToAction(nameof(Index));

            state.IsChecked = true;
            HttpContext.Session.SetObjectAsJson(ExamStateKey, state);

            return RedirectToAction("Index", new
            {
                examSessionIds = state.ExamSessionIds
            });
        }

        [HttpPost]
        public async Task<IActionResult> NewExam(List<int>? examSessionIds)
        {
            var state = await examService.GenerateExamAsync(examSessionIds);
            HttpContext.Session.SetObjectAsJson(ExamStateKey, state);

            return RedirectToAction("Index", new { examSessionIds });
        }
    }
}
