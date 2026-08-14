using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class Card
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public int WorkId { get; set; }

        public string Type { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string? MoreInformationUrl { get; set; }

        public bool IsCorrect { get; set; } = false;

        public bool IsCorrectChecked { get; set; }

        public bool IsAdditional { get; set; }
    }
}
