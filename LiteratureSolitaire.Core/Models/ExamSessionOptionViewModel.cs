using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Models
{
    public class ExamSessionOptionViewModel
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public string Session { get; set; } = null!;

        public string SessionDisplay =>
            Session == "May" ? "Май" :
            Session == "August" ? "Август" :
            Session;
    }
}
