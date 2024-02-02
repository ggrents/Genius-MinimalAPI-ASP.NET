using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface ITrackRepository
    {
        Task<ICollection<Track>> GetTracksByReleaseAsync(int releaseId);
        Task<Track> GetTrackById(int trackId);
    }
}
