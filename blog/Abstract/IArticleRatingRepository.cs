using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Abstract
{
    public interface IArticleRatingRepository
    {
        IEnumerable<ArticleRating> ArticleRatings { get; }
    }
}
