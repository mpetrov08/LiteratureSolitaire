using LiteratureSolitaire.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class DeckViewModel
    {
        public List<CategorySorting>? SelectedCategories { get; set; }

        public int SectionCount { get; set; }
    }
}
