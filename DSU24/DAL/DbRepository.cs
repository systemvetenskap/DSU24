using DSU24.Models;
using DSU24.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace DSU24.DAL
{
    public class DbRepository : IDbRepository
    {
        private readonly SportDbContext _context;
        public DbRepository(SportDbContext context)
        {
            _context = context;
        }

        public async Task<Sport> AddSportAsync(Sport sport)
        {
            var season = _context.Seasons.FirstOrDefault(x => x.Id==1);
            sport.Season = season;
            await _context.Sports.AddAsync(sport);
            await _context.SaveChangesAsync();
            return sport;
        }

        public async Task<IEnumerable<Sport>> GetSportsAsync()
        {
            var sports = await _context.Sports
                .Include(x => x.Season)
                .ToListAsync();

            return sports;  
        }

        public async Task<IEnumerable<Season>> GetSeasonsAsync()
        {
            var seasons = await _context.Seasons
                .Include(x => x.Sports)
                .ToListAsync();

            return seasons;
        }
    }
}
