using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUI.Models;


namespace WebUI.Abstract
{
    public interface IArticleCommentRepository
    {
       IEnumerable<ArticleComment> ArticleComments { get; }
    }
}