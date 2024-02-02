using genius_minimalAPI.Domain.Entities;

namespace genius_minimalAPI.Application.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public Task<ICollection<Article>> GetAllArticlesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetArticleByIdAsync(int articleId)
        {
            throw new NotImplementedException();
        }
    }
}
