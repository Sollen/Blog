using System.Collections.Generic;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EfArticleRepository : IArticleRepository
    {
        EfdbContext _context = new EfdbContext();

        public IEnumerable<Article> Articles
        {
            get { return _context.Articles; }
        }
    }
}