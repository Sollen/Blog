using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using WebUI.Concrete;


namespace WebUI.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        public void AddRating(int articleID)
        {
            EFDBContext context = new EFDBContext();
            int rating = 0;
            var AllRating = context.ArticleRatings.Where<ArticleRating>((x) => x.ArticleID.ArticleID == articleID);
            foreach (var r in AllRating)
            {
                rating += r.ValueRating;
            }

            context.Articles.Where<Article>((x) => x.ArticleID == articleID).FirstOrDefault().Rating = rating;
            context.SaveChanges();

        }


    }
}