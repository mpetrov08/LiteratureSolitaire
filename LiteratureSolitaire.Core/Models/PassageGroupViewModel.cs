using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class PassageGroupViewModel
    {
        public int ExamSessionId { get; set; }

        public List<PassageViewModel> Passages { get; set; } = new List<PassageViewModel>();

        public List<ExamQuestionViewModel> Questions { get; set; } = new List<ExamQuestionViewModel>();
    }
}
