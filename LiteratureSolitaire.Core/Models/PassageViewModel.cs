using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class PassageViewModel
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string? Content { get; set; }

        public string? ImagePath { get; set; }
    }
}
