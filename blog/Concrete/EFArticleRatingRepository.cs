using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EFArticleRatingRepository : IArticleRatingRepository
    {
        EFDBContext context = new EFDBContext();

        public IEnumerable<ArticleRating> ArticleRatings
        {
            get { return context.ArticleRatings; }
        }
    }
}