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
        public ViewResult AddArticle()
        {
            ViewBag.Message = "Введите данные новой статьи";
            return View();
        }

        [HttpPost]
        public RedirectResult AddArticle(Article newArticle)
        {
            context.Articles.Add(newArticle);
            context.SaveChanges();
            ViewBag.Message = "Статья успешно добавленна";
            return Redirect("AddArticle");
        }

        public ViewResult ModifiArticle(int id)
        {
            var article = context.Articles.Find(id);

            return View(article);

        }

        [HttpPost]
        public RedirectToRouteResult ModifiArticle(Article modifiArticle)
        {



            context.Articles.Find(modifiArticle.ArticleID).Assignment(modifiArticle);
            

            context.SaveChanges();

            return RedirectToRoute(new {
                controller = "Home",
                action = "Single",
                id = modifiArticle.ArticleID

            });
        }
    }
}