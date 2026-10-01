using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    public class QuestionType
    {
        [Key]
        [Comment("Question`s Type Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Question`s Type Name")]
        public string Name { get; set; } = null!;

        public IEnumerable<Question> Questions { get; set; } = new List<Question>();
    }
}
