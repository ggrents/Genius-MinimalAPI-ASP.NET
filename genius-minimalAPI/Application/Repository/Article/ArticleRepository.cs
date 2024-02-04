using genius_minimalAPI.Domain.Entities;
using genius_minimalAPI.Infrastructure;
using System.Data.Entity;

namespace genius_minimalAPI.Application.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private GeniusDbContext _db;
        public ArticleRepository(GeniusDbContext db)
        {
            _db = db;
        }
        public async Task<ICollection<Article>> GetAllArticlesAsync()
        {
            return await _db.Articles.ToListAsync();
        }

        public async Task<Article?> GetArticleByIdAsync(int articleId)
        {
            var _article = await _db.Articles.Where(i=>i.Id.Equals(articleId)).FirstOrDefaultAsync();
            if (_article!=null)
            {
                return _article;
            }
            else
            {
                return null;
            }
        }
    }
}
