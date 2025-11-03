using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    [Comment("Author")]
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Author`s Name")]
        public string Name { get; set; } = null!;

        public IEnumerable<Work> Works { get; set; } = new List<Work>();
    }
}
