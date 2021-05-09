using Bakogeorgos_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Services
{
    public interface IMatchService
    {
        Task<IList<Match>> GetAllMatches();
        Task<Match> GetMatchById(int id);
        Task<int> CreateMatch(Match match);
        Task<int> DeleteMatch(int id);
        Task<Match> UpdateMatch(Match match);
    }
}
