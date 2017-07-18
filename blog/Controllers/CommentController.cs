using System;
using System.Linq;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        public EfdbContext Context;
        public CommentController()
        {
            Context = new EfdbContext();
        }


        public JsonResult AddComment(ArticleComment comment)
        {
            comment.CreateDate = DateTime.Now;
            Context.ArticleComments.Add(comment);
            Context.SaveChanges();

            return Json(new { succes = "true"});
        }

        public JsonResult GetComment(int articleId, int lastCommentId = 0)
        {
            var comments = Context.ArticleComments.Where((x) => x.ArticleId.ArticleId == articleId && x.CommentId > lastCommentId);
            return Json(comments);
        }
    }
}