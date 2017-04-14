using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Abstract;
using WebUI.Models;

namespace WebUI.Concrete
{
    public class EFArticleCommentRepository : IArticleCommentRepository
    {
        EFDBContext context = new EFDBContext();

        public IEnumerable<ArticleComment> ArticleComments
        {
            get { return context.ArticleComments; }
        }
    }
}