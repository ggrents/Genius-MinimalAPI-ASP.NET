using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace genius_minimalAPI.Application.Repository
{
    public class TrackRepository : ITrackRepository
    {
        private GeniusDbContext _db;

        public TrackRepository(GeniusDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Track>> GetAllTracksAsync()
        {
            return await _db.Tracks.ToListAsync();
        }

        public async Task<Track?> GetTrackByIdAsync(int trackId)
        {   
            var _track  = await _db.Tracks.Where(i => i.Id.Equals(trackId)).FirstOrDefaultAsync();
            if (_track != null)
            {
                return _track;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Track>> GetTracksByMusicianAsync(int musicianId)
        {
           return await _db.Tracks.Where(i=>_db.Releases.Any(r=>r.MusicianId == musicianId && r.Id == i.ReleaseId))
                .ToListAsync();
        }

        public async Task<IEnumerable<Track>> GetTracksByReleaseAsync(int releaseId)
        {
            return await _db.Tracks.Where(i => i.ReleaseId == releaseId).ToListAsync();
        }

        
    }
}
