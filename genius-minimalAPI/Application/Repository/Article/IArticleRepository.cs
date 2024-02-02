using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public interface IArticleRepository
    {
        Task<ICollection<Article>> GetAllArticlesAsync();
        Task<Article?> GetArticleByIdAsync(int articleId);
    }
}
