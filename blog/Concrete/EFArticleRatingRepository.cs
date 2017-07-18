using System.Collections.Generic;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EfArticleRatingRepository : IArticleRatingRepository
    {
        EfdbContext _context = new EfdbContext();

        public IEnumerable<ArticleRating> ArticleRatings
        {
            get { return _context.ArticleRatings; }
        }
    }
}