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
    public class QuestionPassage
    {
        [Required]
        [Comment("Question Id")]
        public int QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; } = null!;

        [Required]
        [Comment("Passage Id")]
        public int PassageId { get; set; }

        [ForeignKey(nameof(PassageId))]
        public Passage Passage { get; set; } = null!;
    }
}
