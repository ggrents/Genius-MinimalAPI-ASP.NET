using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace genius_minimalAPI.Application.Repository.ReleasesRep
{
    public class ReleasesRepository : IReleaseRepository
    {
        private GeniusDbContext _db;
        public ReleasesRepository(GeniusDbContext db)
        {
            _db = db;
        }
        public async Task<ICollection<Release>> GetAllReleasesAsync()
        {
            return await _db.Releases.ToListAsync();
        }
        public async Task<IEnumerable<Release>> GetReleasesByMusicianAsync(int musicianId)
        {
            return await _db.Releases.Where(r => r.MusicianId == musicianId).ToListAsync();
        }
        public async Task<Release?> GetReleaseByIdAsync(int releaseId)
        {
            var _release = await _db.Releases.Where(i=>i.Equals(releaseId)).FirstOrDefaultAsync();
            if (_release != null)
            {
                return _release;
            }
            else
            {
                return null;
            }
        }
    }
}
