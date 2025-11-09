using LiteratureSolitaire.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Contracts
{
    public interface IDeckService
    {
        Task<List<Card>> GenerateDeckAsync();

        Task<List<Card>> ShuffleDeckAsync(List<Card> cards);
    }
}
