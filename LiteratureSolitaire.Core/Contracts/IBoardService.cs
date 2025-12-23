using LiteratureSolitaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Contracts
{
    public interface IBoardService
    {
        public Task<List<BoardSlot>> ValidateBoardSlots(List<BoardSlot> boardSlots);
    }
}
