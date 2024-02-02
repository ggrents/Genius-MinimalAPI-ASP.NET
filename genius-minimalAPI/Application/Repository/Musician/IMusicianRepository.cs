using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface IMusicianRepository
    {
        Task<ICollection<Musician>> GetAllMusiciansAsync();
        Task<Musician?> GetMusicianByIdAsync(int musicianId);
    }
}
