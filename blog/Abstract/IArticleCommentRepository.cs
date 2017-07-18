using System.Collections.Generic;
using WebUI.Models;


namespace WebUI.Abstract
{
    public interface IArticleCommentRepository
    {
       IEnumerable<ArticleComment> ArticleComments { get; }
    }
}