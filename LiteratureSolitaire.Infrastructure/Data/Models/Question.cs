using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    public class Question
    {
        [Key]
        [Comment("Question Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Question`s Content")]
        public string Content { get; set; } = null!;

        [Required]
        [Comment("Question`s Type")]
        public int QuestionTypeId { get; set; }

        [ForeignKey(nameof(QuestionTypeId))]
        public QuestionType QuestionType { get; set; } = null!;

        [Required]
        [Comment("Question`s Exam Session")]
        public int ExamSessionId { get; set; }

        [ForeignKey(nameof(ExamSessionId))]
        public ExamSession ExamSession { get; set; } = null!;

        public IEnumerable<Answer> Answers { get; set; } = new List<Answer>();

        public ICollection<QuestionPassage> QuestionPassages { get; set; } = new List<QuestionPassage>();

    }
}
