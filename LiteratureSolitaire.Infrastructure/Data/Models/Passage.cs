using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    public class Passage
    {
        [Key]
        [Comment("Passage Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Passage Number")]
        public int Number { get; set; }

        [Comment("Passage Text Content")]
        public string? Content { get; set; }

        [Comment("Path to the Passage Image")]
        public string? ImagePath { get; set; }

        [Required]
        [Comment("Passage`s Exam Session")]
        public int ExamSessionId { get; set; }

        [ForeignKey(nameof(ExamSessionId))]
        public ExamSession ExamSession { get; set; } = null!;

        public ICollection<QuestionPassage> QuestionPassages { get; set; } = new List<QuestionPassage>();
    }
}
