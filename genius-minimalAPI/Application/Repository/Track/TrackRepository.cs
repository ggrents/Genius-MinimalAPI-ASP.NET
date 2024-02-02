using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using System.Data.Entity;

namespace genius_minimalAPI.Application.Repository
{
    public class TrackRepository : ITrackRepository
    {
        private GeniusDbContext _db;

        public TrackRepository(GeniusDbContext db)
        {
            _db = db;
        }

        public async Task<Track> GetTrackById(int trackId)
        {
            return await _db.Tracks.Where(i => i.Id.Equals(trackId)).FirstOrDefaultAsync();
        }

        public async Task<ICollection<Track>> GetTracksByReleaseAsync(int releaseId)
        {
            return await _db.Tracks.Where(i => i.ReleaseId == releaseId).ToListAsync();
        }
    }
}
