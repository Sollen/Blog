using System.Collections.Generic;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EFArticleRepository : IArticleRepository
    {
        EFDBContext context = new EFDBContext();

        public IEnumerable<Article> Articles
        {
            get { return context.Articles; }
        }
    }
}