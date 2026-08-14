using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class AdditionalCardsViewModel
    {
        public List<AdditionalCardWorkViewModel> Works { get; set; } = new();
    }
}
