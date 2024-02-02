using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface IReleaseRepository
    {
        Task<ICollection<Release>> GetReleasesByMusicianAsync(int musicianId);
        Task<Release> GetReleaseByIdAsync(int releaseId);
    }
}
