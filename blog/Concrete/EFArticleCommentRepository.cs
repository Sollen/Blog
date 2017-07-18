using System.Collections.Generic;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EfArticleCommentRepository : IArticleCommentRepository
    {
        EfdbContext _context = new EfdbContext();

        public IEnumerable<ArticleComment> ArticleComments
        {
            get { return _context.ArticleComments; }
        }
    }
}