using Bakogeorgos_test.Models;
using Bakogeorgos_test.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Services
{
    public class MatchOddsService : IMatchOddService
    {
        private readonly AppDbContext _db;

        public MatchOddsService(AppDbContext db)
        {
            _db = db;

        }
        public async Task<int> CreateMatchOdds(MatchOdd matchOdd)
        {
            var mtch = new MatchOdd
            {
                MatchId=matchOdd.ID,
                Odd=matchOdd.Odd,
                Specifier=matchOdd.Specifier
            };
            
            await _db.MatchOdds.AddAsync(mtch);
            await _db.SaveChangesAsync();
            return mtch.MatchId;
        }

        public async Task<int> DeleteMatchOdds(int id)
        {
            var matchOdd = await _db.MatchOdds.FirstOrDefaultAsync(m => m.ID == id);
            _db.MatchOdds.Remove(matchOdd);
            await _db.SaveChangesAsync();
            return matchOdd.ID;
        }

        public async Task<IList<MatchOdd>> GetAllMatchOdds()
        {
            return await _db.MatchOdds.ToListAsync();
        }

        public async Task<MatchOdd> GetMatchOddsById(int id)
        {
            var match = await _db.MatchOdds.SingleOrDefaultAsync(m => m.ID == id);
            return match;
        }

        public async Task<MatchOdd> UpdateMatchOdds(MatchOdd updatedMatchOdd)
        {
            var matchOdd = await GetMatchOddsById(updatedMatchOdd.ID);
            _db.MatchOdds.Attach(matchOdd);
            _db.Entry(matchOdd).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return matchOdd;
        }
    }
}
