using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class ArticleComment
    {
        [Key]
        public int CommentId { get; set; }
        public string Text { get; set; }
        public Article ArticleId { get; set; }
        public int ParrentComment { get; set; }
        public int Rating { get; set; }
        public DateTime CreateDate { get; set; }
    }
}