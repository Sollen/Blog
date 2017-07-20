using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using WebUI.Concrete;


namespace WebUI.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public DateTime CreateDate { get; set; }

        public void CalcRating()
        {
            EfdbContext context = new EfdbContext();
            int rating = 0;
            var allRating = context.ArticleRatings.Where((x) => x.ArticleId.ArticleId == ArticleId);
            foreach (var r in allRating)
            {
                rating += r.ValueRating;
            }

            context.Articles.FirstOrDefault(x => x.ArticleId == ArticleId).Rating = rating;
            context.SaveChanges();

        }

        public void Assignment(Article newArticle)
        {
            ArticleId = newArticle.ArticleId;
            Description = newArticle.Description;
            Rating = newArticle.Rating;
            Text = newArticle.Text;
            Title = newArticle.Title;
            CreateDate = newArticle.CreateDate;
        }


    }
}