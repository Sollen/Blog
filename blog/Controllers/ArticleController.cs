using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ArticleController : Controller
    {
        public EFDBContext context;

        public ArticleController()
        {
            context = new EFDBContext();
        }
        public ActionResult AddArticle()
        {
            ViewBag.Message = "Введите данные новой статьи";
            return View();
        }

        [HttpPost]
        public ActionResult AddArticle(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            ViewBag.Message = "Статья успешно добавленна";
            return View();
        }
    }
}