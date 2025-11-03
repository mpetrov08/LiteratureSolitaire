using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    [Comment("Literary Direction")]
    public class LiteraryDirection
    {
        [Key]
        [Comment("Literary Direction Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Literary Direction Name")]
        public string Name { get; set; } = null!;

        public IEnumerable<Work> Works { get; set; } = new List<Work>();
    }
}
