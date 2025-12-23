using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    [Comment("Work")]
    public class Work
    {
        [Key]
        [Comment("Work Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Work Title")]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Work Author")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;

        [Required]
        [Comment("Work Characters")]
        public string Characters { get; set; } = null!; 

        [Required]
        [Comment("Work Genre")]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;

        [Required]
        [Comment("Work Literary Direction")]
        public int LiteraryDirectionId { get; set; }

        [ForeignKey(nameof(LiteraryDirectionId))]
        public LiteraryDirection LiteraryDirection { get; set; } = null!;

        [Required]
        [Comment("Work Category")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}
