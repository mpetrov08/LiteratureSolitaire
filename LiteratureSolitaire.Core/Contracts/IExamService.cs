using LiteratureSolitaire.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Contracts
{
    public interface IExamService
    {
        Task<List<ExamSessionOptionViewModel>> GetAvailableExamSessionsAsync();

        Task<ExamState> GenerateExamAsync(List<int>? examSessionIds, int? questionTypeId = null);

        Task<ExamViewModel> BuildViewModelAsync(ExamState state);
    }
}
