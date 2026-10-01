using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class ExamQuestionViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public string QuestionTypeName { get; set; } = null!;

        public List<AnswerViewModel> Answers { get; set; } = new List<AnswerViewModel>();

        public bool IsChecked { get; set; }

        public bool? IsCorrect { get; set; }
    }
}
