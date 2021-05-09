using Bakogeorgos_test.Models;
using Bakogeorgos_test.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakogeorgos_test.Services
{
    public class MatchService : IMatchService
    {
        private readonly AppDbContext _db;

        public MatchService(AppDbContext db)
        {
            _db = db;

        }

        public async Task<int> CreateMatch(Match match)
        {
            var result = await _db.Matches.AddAsync(match);
            await _db.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<int> DeleteMatch(int id)
        {
            var match = await _db.Matches.FirstOrDefaultAsync(m => m.Id == id);
            _db.Matches.Remove(match);
            await _db.SaveChangesAsync();
            return match.Id;
        }

        public async Task<IList<Match>> GetAllMatches()
        {
            return await _db.Matches.ToListAsync();

        }

        public async Task<Match> GetMatchById(int id)
        {
            var match = await _db.Matches.SingleOrDefaultAsync(m => m.Id == id);
            return match;
        }

        public async Task<Match> UpdateMatch(Match updatedMatch)
        {
            var match = await GetMatchById(updatedMatch.Id);
            _db.Matches.Attach(match);
            _db.Entry(match).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return match;
        }
    }
}
