using LiteratureSolitaire.Core.Models;

namespace LiteratureSolitaire.Models
{
    public class BoardSlot
    {
        public int Section { get; set; } 
        public int Position { get; set; } 
        public Card? Card { get; set; }
    }
}
