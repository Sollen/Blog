using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class ArticleRating
    {
        [Key]
        public int RatingId { get; set; }               
        public int ValueRating { get; set; }
        public Article ArticleId { get; set; }

    }
}