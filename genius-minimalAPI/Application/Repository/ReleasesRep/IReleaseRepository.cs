using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface IReleaseRepository
    {
        Task<IQueryable<Release>> GetReleasesByMusician(int musicianId);
    }
}
