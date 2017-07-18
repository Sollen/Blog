using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RatingController : Controller
    {
        public EfdbContext Context;
        public RatingController()
        {
            Context = new EfdbContext();
        }
        public JsonResult AddRating(int id, int rating)
        {
            var articleRating = new ArticleRating
            {
                ArticleId = Context.Articles.Find(id),
                ValueRating = rating
            };

            Context.ArticleRatings.Add(articleRating);
            Context.SaveChanges();
            Context.Articles.Find(id).CalcRating();

            return Json(new { newrating = Context.Articles.Find(id).Rating, succes = "true" });


        }

        public JsonResult RequestRating(int id)
        {


            return Json(new { articleID = id, rating = Context.Articles.Find(id).Rating});

        }


    }
}   