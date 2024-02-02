using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface ITrackRepository
    {
        Task<IEnumerable<Track>> GetTracksByReleaseAsync(int releaseId);
        Task<Track> GetTrackByIdAsync(int trackId);
        Task<IEnumerable<Track>> GetTracksByMusicianAsync(int trackId);
    }
}
