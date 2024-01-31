using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface ITrackRepository
    {
        Task<IQueryable<Track>> GetTracksByRelease(int releaseId);
    }
}
