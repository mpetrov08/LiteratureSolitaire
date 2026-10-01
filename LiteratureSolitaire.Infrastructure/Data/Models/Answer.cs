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
    public class Answer
    {
        [Key]
        [Comment("Answer Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Answer`s Content")]
        public string Content { get; set; } = null!;

        [Required]
        [Comment("Is the Answer Correct")]
        public bool IsCorrect { get; set; } 

        [Required]
        [Comment("Question Id")]
        public int QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; } = null!;
    }
}
