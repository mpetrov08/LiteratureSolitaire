using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class ExamViewModel
    {
        public List<int> SelectedExamSessionIds { get; set; } = new List<int>();

        public List<ExamSessionOptionViewModel> AvailableExamSessions { get; set; } = new List<ExamSessionOptionViewModel>();

        public List<PassageGroupViewModel> PassageGroups { get; set; } = new List<PassageGroupViewModel>();

        public List<ExamQuestionViewModel> StandaloneQuestions { get; set; } = new List<ExamQuestionViewModel>();

        public bool IsChecked { get; set; }

        public int? CorrectCount { get; set; }

        public int? TotalCount { get; set; }
    }
}
