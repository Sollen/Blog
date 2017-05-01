using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Concrete;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RatingController : Controller
    {
        public EFDBContext context;
        public RatingController()
        {
            context = new EFDBContext();
        }
        public JsonResult AddRating(int id, int rating)
        {
            ArticleRating articleRating = new ArticleRating();
            articleRating.ArticleID = context.Articles.Find(id);
            articleRating.ValueRating = rating;

            context.ArticleRatings.Add(articleRating);
            context.SaveChanges();
            context.Articles.Find(id).CalcRating();

            return Json(new { newrating = context.Articles.Find(id).Rating, succes = "true" });


        }

        public JsonResult RequestRating(int id)
        {


            return Json(new { articleID = id, rating = context.Articles.Find(id).Rating});

        }


    }
}   