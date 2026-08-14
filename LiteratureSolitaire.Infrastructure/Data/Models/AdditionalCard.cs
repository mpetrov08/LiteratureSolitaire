using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Infrastructure.Data.Models
{
    public class AdditionalCard
    {
        [Key]
        [Comment("Additional Card Indetifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User Id")]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }

        [Required]
        [Comment("Work Id")]
        public int WorkId { get; set; }

        [ForeignKey(nameof(WorkId))]
        public Work Work { get; set; }

        [Required]
        [Comment("Type of the card")]
        public string Type { get; set; }

        [Required]
        [Comment("Content of the card")]
        public string Content { get; set; }
    }
}
