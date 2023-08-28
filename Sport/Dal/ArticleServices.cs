using Sport.Bll;
using Sport.Models;

namespace Sport.Dal
{
    public class ArticleServices
    {
        private readonly Context _context;
        public ArticleServices(Context context)
        {
            _context = context;
        }

        public async Task<ArticleViewModel?> GetArticle(int articleId)
        {
            return await _context.GetArticleById(articleId);
        }

        public async Task<List<ArticleViewModel?>?> GetArticles(int page = 1, int amount = 10)
        {
            return await _context.GetArticles(page, amount);
        }
    }
}
