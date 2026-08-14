using LiteratureSolitaire.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class AdditionalCardWorkViewModel
    {
        public int WorkId { get; set; }

        public string WorkTitle { get; set; } = string.Empty;

        public List<Card> DefaultCards { get; set; } = new();

        public List<AdditionalCard> AdditionalCards { get; set; } = new();
    }
}
