using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    [Comment("Genre")]
    public class Genre
    {
        [Key]
        [Comment("Genre Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Genre Name")]
        public string Name { get; set; } = null!;

        public IEnumerable<Work> Works { get; set; } = new List<Work>();
    }
}
