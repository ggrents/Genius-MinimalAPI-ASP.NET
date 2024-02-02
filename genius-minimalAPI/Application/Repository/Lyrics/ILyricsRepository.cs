using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface ILyricsRepository
    {
        Task<Lyrics?> GetLyricsByTrackAsync(int trackId);
    }
}
