using System.Collections.Generic;
using WebUI.Models;

namespace WebUI.Abstract
{
    public interface IArticleRatingRepository
    {
        IEnumerable<ArticleRating> ArticleRatings { get; }
    }
}
