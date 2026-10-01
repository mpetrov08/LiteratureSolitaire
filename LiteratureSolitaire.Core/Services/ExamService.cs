using LiteratureSolitaire.Core.Contracts;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Infrastructure.Data.Models;
using LiteratureSolitaire.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Services
{
    public class ExamService : IExamService
    {
        private readonly IRepository repository;

        private static readonly Dictionary<string, string> QuestionTypeDisplayNames = new()
        {
            ["SpellingNorm"] = "Правописна норма",
            ["GrammarNorm"] = "Граматична норма",
            ["PunctuationNorm"] = "Пунктуационна норма",
            ["ReadingComprehension"] = "Четене с разбиране",
            ["LiteratureStudiedWorks"] = "Литература – изучавани произведения",
            ["LiteratureUnstudiedWorks"] = "Литература – неизучавано произведение",
            ["PunctuationText"] = "Поставяне на препинателни знаци в текст"
        };

        private static readonly Dictionary<string, int> QuestionsPerType = new()
        {
            ["SpellingNorm"] = 3,
            ["GrammarNorm"] = 2,
            ["PunctuationNorm"] = 2,
            ["ReadingComprehension"] = 4,
            ["LiteratureStudiedWorks"] = 10,
            ["LiteratureUnstudiedWorks"] = 1,
            ["PunctuationText"] = 1
        };

        public ExamService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<List<ExamSessionOptionViewModel>> GetAvailableExamSessionsAsync()
        {
            return await repository
                .AllReadОnly<ExamSession>()
                .OrderByDescending(s => s.Year)
                .Select(s => new ExamSessionOptionViewModel
                {
                    Id = s.Id,
                    Year = s.Year,
                    Session = s.Session
                })
                .ToListAsync();
        }

        public async Task<ExamState> GenerateExamAsync(List<int>? examSessionIds, int? questionTypeId = null)
        {
            var typesQuery = repository.AllReadОnly<QuestionType>();

            if (questionTypeId.HasValue)
                typesQuery = typesQuery.Where(t => t.Id == questionTypeId.Value);

            var questionTypes = await typesQuery.ToListAsync();

            var selectedQuestionIds = new List<int>();

            foreach (var type in questionTypes)
            {
                var count = GetQuestionCount(type.Name, questionTypeId.HasValue);

                if (type.Name == "ReadingComprehension")
                {
                    selectedQuestionIds.AddRange(
                        await PickReadingComprehensionAsync(type.Id, count, examSessionIds));
                    continue;
                }

                var pool = repository
                    .AllReadОnly<Question>()
                    .Where(q => q.QuestionTypeId == type.Id);

                if (examSessionIds != null && examSessionIds.Any())
                {
                    pool = pool.Where(q => examSessionIds.Contains(q.ExamSessionId));
                }

                var poolIds = await pool
                    .Select(q => q.Id)
                    .ToListAsync();

                var chosen = poolIds
                    .OrderBy(_ => Random.Shared.Next())
                    .Take(count)
                    .ToList();

                selectedQuestionIds.AddRange(chosen);
            }

            return new ExamState
            {
                ExamSessionIds = examSessionIds ?? new List<int>(),
                QuestionIds = selectedQuestionIds,
                SelectedAnswers = selectedQuestionIds.ToDictionary(id => id, _ => (int?)null),
                IsChecked = false
            };
        }

        public async Task<ExamViewModel> BuildViewModelAsync(ExamState state)
        {
            var availableSessions = await GetAvailableExamSessionsAsync();

            var questions = await repository
                .AllReadОnly<Question>()
                .Include(q => q.QuestionType)
                .Include(q => q.Answers)
                .Include(q => q.QuestionPassages)
                .ThenInclude(qp => qp.Passage)
                .Where(q => state.QuestionIds.Contains(q.Id))
                .ToListAsync();

            var questionTypes = await repository
                .AllReadОnly<QuestionType>()
                .ToListAsync();

            var viewModel = new ExamViewModel
            {
                SelectedExamSessionIds = state.ExamSessionIds,
                SelectedQuestionTypeId = state.QuestionTypeId,
                AvailableQuestionTypes = questionTypes
                    .Select(t => new QuestionTypeOptionViewModel
                    {
                        Id = t.Id,
                        Display = QuestionTypeDisplayNames.GetValueOrDefault(t.Name, t.Name)
                    })
                    .ToList(),
                AvailableExamSessions = availableSessions,
                IsChecked = state.IsChecked
            };

            var passageQuestions = questions.Where(q => q.QuestionPassages.Any()).ToList();
            var standaloneQuestions = questions.Where(q => !q.QuestionPassages.Any()).ToList();

            var passageGroups = passageQuestions
                .GroupBy(q => q.QuestionPassages.First().Passage.ExamSessionId);

            foreach (var group in passageGroups)
            {
                var passages = group
                    .SelectMany(q => q.QuestionPassages.Select(qp => qp.Passage))
                    .GroupBy(p => p.Id)
                    .Select(g => g.First())
                    .OrderBy(p => p.Number)
                    .Select(MapPassage)
                    .ToList();

                viewModel.PassageGroups.Add(new PassageGroupViewModel
                {
                    ExamSessionId = group.Key,
                    Passages = passages,
                    Questions = group.Select(q => MapQuestion(q, state)).ToList()
                });
            }

            viewModel.StandaloneQuestions = standaloneQuestions
                .Select(q => MapQuestion(q, state))
                .ToList();

            if (state.IsChecked)
            {
                var allQuestions = viewModel.PassageGroups
                    .SelectMany(g => g.Questions)
                    .Concat(viewModel.StandaloneQuestions)
                    .ToList();

                viewModel.TotalCount = allQuestions.Count;
                viewModel.CorrectCount = allQuestions.Count(q => q.IsCorrect == true);
            }

            return viewModel;
        }

        private PassageViewModel MapPassage(Passage passage)
        {
            return new PassageViewModel
            {
                Id = passage.Id,
                Number = passage.Number,
                Content = passage.Content,
                ImagePath = passage.ImagePath
            };
        }

        private ExamQuestionViewModel MapQuestion(Question question, ExamState state)
        {
            if (question.QuestionType.Name == "PunctuationText")
                return MapTextQuestion(question, state);

            int? selectedAnswerId = state.SelectedAnswers.GetValueOrDefault(question.Id);

            var answerViewModels = question.Answers.Select(a => new AnswerViewModel
            {
                Id = a.Id,
                Content = a.Content,
                IsSelected = a.Id == selectedAnswerId,
                IsCorrect = state.IsChecked ? a.IsCorrect : null
            }).ToList();

            bool? isCorrect = null;

            if (state.IsChecked)
            {
                isCorrect = selectedAnswerId.HasValue &&
                    question.Answers.Any(a => a.Id == selectedAnswerId && a.IsCorrect);
            }

            return new ExamQuestionViewModel
            {
                Id = question.Id,
                Content = question.Content,
                QuestionTypeName = question.QuestionType.Name,
                Answers = answerViewModels,
                IsChecked = state.IsChecked,
                IsCorrect = isCorrect
            };
        }

        private ExamQuestionViewModel MapTextQuestion(Question question, ExamState state)
        {
            var parts = question.Content.Split(new[] { "\r\n" }, 2, StringSplitOptions.None);
            var originalText = parts.Length > 1 ? parts[1] : string.Empty;

            var correctText = question.Answers
                .FirstOrDefault(a => a.IsCorrect)?.Content ?? string.Empty;

            state.TextAnswers.TryGetValue(question.Id, out var userText);

            return new ExamQuestionViewModel
            {
                Id = question.Id,
                Content = parts[0],
                QuestionTypeName = question.QuestionType.Name,
                IsTextQuestion = true,
                UserText = userText ?? originalText,
                CorrectText = state.IsChecked ? correctText : null,
                IsChecked = state.IsChecked,
                IsCorrect = state.IsChecked
                    ? IsCorrectPunctuationText(userText, correctText)
                    : null
            };
        }

        private async Task<List<int>> PickReadingComprehensionAsync(int questionTypeId, int count, List<int>? examSessionIds)
        {
            var query = repository
                .AllReadОnly<Question>()
                .Where(q => q.QuestionTypeId == questionTypeId
                         && q.QuestionPassages.Any());

            if (examSessionIds != null && examSessionIds.Any())
            {
                query = query.Where(q => examSessionIds.Contains(q.ExamSessionId));
            }

            var rows = await query
                .Select(q => new
                {
                    q.Id,
                    q.ExamSessionId,
                    Passages = q.QuestionPassages
                        .Select(qp => new { qp.PassageId, PassageSessionId = qp.Passage.ExamSessionId })
                        .OrderBy(p => p.PassageId)
                        .ToList()
                })
                .ToListAsync();

            var sets = rows
                .Where(r => r.Passages.Count == 2
                         && r.Passages.All(p => p.PassageSessionId == r.ExamSessionId))
                .GroupBy(r => string.Join(",", r.Passages.Select(p => p.PassageId)))
                .ToList();

            if (!sets.Any())
                return new List<int>();

            var eligible = sets.Where(g => g.Count() >= count).ToList();

            var chosenSet = eligible.Any()
                ? eligible[Random.Shared.Next(eligible.Count)]
                : sets.OrderByDescending(g => g.Count()).First();

            return chosenSet
                .Select(r => r.Id)
                .OrderBy(_ => Random.Shared.Next())
                .Take(count)
                .ToList();
        }

        public static bool IsCorrectPunctuationText(string? userText, string correctText)
        {
            if (string.IsNullOrWhiteSpace(userText) || string.IsNullOrWhiteSpace(correctText))
                return false;

            var user = Parse(userText);
            var correct = Parse(correctText);

            return user.Words.SequenceEqual(correct.Words, StringComparer.OrdinalIgnoreCase)
                && user.Gaps.Count == correct.Gaps.Count
                && user.Gaps.All(g => correct.Gaps.TryGetValue(g.Key, out var v) && v == g.Value);
        }

        private static readonly Regex TokenRegex = new(@"[\p{L}\p{N}]+|[^\s\p{L}\p{N}]", RegexOptions.Compiled);

        private static (List<string> Words, Dictionary<int, string> Gaps) Parse(string text)
        {
            var words = new List<string>();
            var gaps = new Dictionary<int, string>();

            foreach (Match m in TokenRegex.Matches(Normalize(text)))
            {
                if (char.IsLetterOrDigit(m.Value[0]))
                {
                    words.Add(m.Value);
                }
                else
                {
                    gaps[words.Count] = gaps.GetValueOrDefault(words.Count, "") + m.Value;
                }
            }

            return (words, gaps);
        }

        private static string Normalize(string text) => text
           .Replace('„', '"').Replace('“', '"').Replace('”', '"')
           .Replace('«', '"').Replace('»', '"')
           .Replace('—', '–').Replace('−', '–').Replace('-', '–')
           .Replace("…", "...");

        private static int GetQuestionCount(string typeName, bool singleCategory)
        {
            if (!singleCategory)
                return QuestionsPerType[typeName];

            return typeName switch
            {
                "ReadingComprehension" => 4, 
                "PunctuationText" => 3,       
                _ => 10
            };
        }
    }
}
