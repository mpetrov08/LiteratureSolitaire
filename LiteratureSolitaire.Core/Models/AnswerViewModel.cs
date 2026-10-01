using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class AnswerViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; } = null!;

        public bool IsSelected { get; set; }

        public bool? IsCorrect { get; set; }
    }
}
