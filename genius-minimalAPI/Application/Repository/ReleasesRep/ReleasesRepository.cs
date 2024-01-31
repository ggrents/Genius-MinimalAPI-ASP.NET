using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using System.Data.Entity;

namespace genius_minimalAPI.Application.Repository.ReleasesRep
{
    public class ReleasesRepository : IReleaseRepository
    {
        private GeniusDbContext _db;
        public ReleasesRepository(GeniusDbContext db)
        {
            _db = db;
        }
        public async Task<IQueryable<Release>> GetReleasesByMusician(int musicianId)
        {
            return await _db.Releases.Where(r => r.MusicianId ==  musicianId).ToListAsync();
        }
    }
}
