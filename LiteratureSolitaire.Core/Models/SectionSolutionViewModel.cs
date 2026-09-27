using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class SectionSolutionViewModel
    {
        public int Section { get; set; }
        public List<Card> Cards { get; set; } = new();
    }
}