using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface IMusicianRepository
    {
        Task<IEnumerable<Musician>> GetAllMusiciansAsync();
    }
}
