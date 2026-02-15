using LiteratureSolitaire.Core.Enumerations;
using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Contracts
{
    public interface IDeckService
    {
        Task<List<Card>> GenerateDeckAsync(List<CategorySorting>? categories = null);

        Task<List<Card>> ShuffleDeckAsync(List<Card> cards);

        Task<List<Work>> FilterCards(List<CategorySorting>? categories = null);
    }
}
