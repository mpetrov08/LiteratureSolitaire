using LiteratureSolitaire.Core.Models;
using LiteratureSolitaire.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Contracts
{
    public interface IAdditionalCardService
    {
        Task AddAsync(
            string userId,
            int workId,
            string type,
            string content);

        Task<List<AdditionalCard>> GetByUserAsync(string userId);

        Task<AdditionalCard?> GetByIdAsync(int id, string userId);

        Task DeleteAsync(int id, string userId);

        Task<AdditionalCardsViewModel> GetPageDataAsync(string userId);
    }
}
