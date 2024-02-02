using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace genius_minimalAPI.Application.Repository
{
    public class LyricsRepository : ILyricsRepository
    {
        private GeniusDbContext _db;

        public LyricsRepository(GeniusDbContext db)
        {
            _db = db;
        }
        public async Task<Lyrics?> GetLyricsByTrackAsync(int trackId)
        {
            var _lyrics = await _db.Lyrics.Where(i => i.Equals(trackId)).FirstOrDefaultAsync();
            if (_lyrics != null)
            {
                return _lyrics;
            }
            else
            {
                return null;
            }
        }
    }
}
