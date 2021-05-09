using Bakogeorgos_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Services
{
    public interface IMatchOddService
    {
        Task<IList<MatchOdd>> GetAllMatchOdds();
        Task<MatchOdd> GetMatchOddsById(int id);
        Task<int> CreateMatchOdds(MatchOdd matchOdd);
        Task<int> DeleteMatchOdds(int id);
        Task<MatchOdd> UpdateMatchOdds(MatchOdd matchOdd);
    }
}
