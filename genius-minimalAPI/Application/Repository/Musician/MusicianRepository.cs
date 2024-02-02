using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using System.Data.Entity;

namespace genius_minimalAPI.Application.Repository
{
    public class MusicianRepository : IMusicianRepository
    {
        private GeniusDbContext _db;
        public MusicianRepository(GeniusDbContext db) {
            _db = db;
        }
        public async Task<IEnumerable<Musician>> GetAllMusiciansAsync()
        {
            return await _db.Musicians.ToListAsync();
        }

        public async Task<Musician> GetMusicianByIdAsync(int musicianId)
        {
            return await _db.Musicians.Where(i=>i.Id.Equals(musicianId)).FirstOrDefaultAsync();
        }
    }
}
