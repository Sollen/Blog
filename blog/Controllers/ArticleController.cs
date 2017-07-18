using System;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ArticleController : Controller
    {
        public EfdbContext Context;

        public ArticleController()
        {
            Context = new EfdbContext();
        }
        public ViewResult AddArticle()
        {
            ViewBag.Message = "Введите данные новой статьи";
            return View();
        }

        [HttpPost]
        public RedirectResult AddArticle(Article newArticle)
        {
            newArticle.CreateDate = DateTime.Now;
            Context.Articles.Add(newArticle);
            Context.SaveChanges();
            ViewBag.Message = "Статья успешно добавленна";
            return Redirect("AddArticle");
        }

        public ViewResult ModifiArticle(int id)
        {
            var article = Context.Articles.Find(id);

            return View(article);

        }

        [HttpPost]
        public RedirectToRouteResult ModifiArticle(Article modifiArticle)
        {
            var article = Context.Articles.Find(modifiArticle.ArticleId);

            article.Assignment(modifiArticle);


            Context.SaveChanges();

            return RedirectToRoute(new {
                controller = $"Home",
                action = $"Single",
                id = modifiArticle.ArticleId

            });
        }
    }
}