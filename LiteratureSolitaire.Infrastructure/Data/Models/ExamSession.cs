using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    public class ExamSession
    {
        [Key]
        [Comment("Exam Session Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Year of the Exam")]
        public int Year { get; set; }

        [Required]
        [Comment("Session of the Exam")]
        public string Session { get; set; } = null!;

        public IEnumerable<Question> Questions { get; set; } = new List<Question>();
    }
}
