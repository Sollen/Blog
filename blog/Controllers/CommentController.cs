using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        public EFDBContext context;
        public CommentController()
        {
            context = new EFDBContext();
        }


        public JsonResult AddComment(ArticleComment comment)
        {

            context.ArticleComments.Add(comment);
            context.SaveChanges();

            return Json(new { succes = "true"});
        }

        public JsonResult GetComment(int ArticleID, int LastCommentID = 0)
        {
            var comments = context.ArticleComments.Where<ArticleComment>((x) => x.ArticleID.ArticleID == ArticleID && x.CommentID > LastCommentID);
            return Json(comments);
        }
    }
}